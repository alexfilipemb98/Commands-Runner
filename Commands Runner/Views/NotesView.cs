using Commands_Runner.Data;
using Commands_Runner.Forms;
using Commands_Runner.Helpers;
using Commands_Runner.Models;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraRichEdit;
using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commands_Runner.Views
{
    public partial class NotesListView : DevExpress.XtraEditors.XtraUserControl
    {
        public NotesListView() => InitializeComponent();

        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string name = string.Empty;
            if (TextInputForm.SD(ref name) == DialogResult.OK)
                CreateTab(new NoteModel { Name = name });
        }

        private void CreateTab(NoteModel note)
        {
            int count = xtraTabControl.TabPages.Count + 1;

            // Create a new tab page
            XtraTabPage xtraTabPage = new XtraTabPage();
            xtraTabPage.Name = $"xtraTabPage{count}";
            xtraTabPage.Text = note.Name;
            xtraTabPage.Tag = note.Id;
            xtraTabPage.PageVisible = true;

            RichEditControl richEdit = new RichEditControl();
            richEdit.Dock = DockStyle.Fill;
            richEdit.Name = $"richEdit{count}";
            richEdit.BorderStyle = BorderStyles.NoBorder;
            richEdit.Margin = new Padding(0);
            richEdit.HtmlText = note.Text;
            richEdit.Options.DocumentSaveOptions.CurrentFormat = DocumentFormat.PlainText;
            richEdit.Options.HorizontalScrollbar.Visibility = RichEditScrollbarVisibility.Hidden;
            richEdit.Options.Printing.PrintPreviewFormKind = PrintPreviewFormKind.Bars;
            richEdit.MenuManager = this.barManager;
            richEdit.ActiveViewType = RichEditViewType.Simple;
            richEdit.SpellChecker = this.spellChecker;

            richEdit.GotFocus += (object sender, EventArgs e) =>
            {
                richEditBarController.Control = richEdit;
            };

            xtraTabPage.Controls.Add(richEdit);

            xtraTabControl.TabPages.Add(xtraTabPage);
        }

        public void LoadData(bool showmsg = true)
        {
            Task.Run(() =>
            {
                if (this.InvokeRequired)
                    this.Invoke((MethodInvoker)(() => ld()));
                else
                    ld();

                void ld()
                {
                    List<NoteModel> notesList = NotesData.GetAll();
                    xtraTabControl.TabPages.Clear();
                    foreach (NoteModel note in notesList)
                    {
                        CreateTab(note);
                    }

                    if (showmsg)
                        AppHelper.SetStatus($"'{notesList.Count}' notes found!", Color.Green);
                }
            })
            .ContinueWith(t =>
            {
                xtraTabControl.Refresh();
            }, TaskScheduler.FromCurrentSynchronizationContext());

        }

        private void xtraTabControl_CloseButtonClick(object sender, EventArgs e)
        {
            XtraTabPage page = xtraTabControl.SelectedTabPage;

            if (page != null && XtraMessageBox.Show($"Do you really want to delete '{page.Text}'", "Delete Note?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NotesData.Delete(int.Parse(page.Tag.ToString()));
                xtraTabControl.TabPages.Remove(page);
            }
        }

        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e) => SaveData();

        public void SaveData()
        {
            Task.Run(() =>
            {
                foreach (XtraTabPage tabPage in xtraTabControl.TabPages.ToList<XtraTabPage>())
                {
                    NoteModel note = new NoteModel();

                    note.Id = int.Parse(tabPage.Tag?.ToString());
                    note.Name = tabPage.Text;

                    foreach (var tabPageControl in tabPage.Controls)
                    {
                        if (tabPageControl is RichEditControl richEdit)
                            richEdit.Invoke((MethodInvoker)(() => note.Text = richEdit.HtmlText));
                    }

                    NotesData.Save(note);

                    tabPage.Tag = note.Id;
                }
            })
            .ContinueWith(t =>
            {
                AppHelper.SetStatus($"Notes Saved!", Color.Green);
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void bbiEditName_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraTabPage page = xtraTabControl.SelectedTabPage;

            if (page != null)
            {
                string name = page.Text;
                if (TextInputForm.SD(ref name) == DialogResult.OK)
                    page.Text = name;
            }
        }

        private void bbiExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveData();

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = "Notes.xml";
                saveFileDialog.Filter = "XML files (*.xml)|*.xml";
                saveFileDialog.Title = $"Export Notes";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string destinationFilePath = saveFileDialog.FileName;

                    RootNotesModel notes = new RootNotesModel();
                    notes.NoteList = NotesData.GetAll();

                    string xml = AppHelper.SerializeToXml(notes);
                    File.WriteAllText(destinationFilePath, xml);
                }
            }
        }

        private void bbiImport_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.FileName = "Notes.xml";
                    openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                    openFileDialog.Title = $"Select the source file";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string sourceFilePath = openFileDialog.FileName;
                        string xml = File.ReadAllText(sourceFilePath);
                        RootNotesModel notes = AppHelper.DeserializeFromXml<RootNotesModel>(xml);

                        NotesData.Import(notes.NoteList);
                    }
                }

                LoadData();
            }
            catch (Exception ex)
            {
                AppHelper.ErrorHandler(ex);
            }
        }

        private void xtraTabControl_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
        {
            if (e.Page == null)
                richEditBarController.Control = null;
        }

    }
}
