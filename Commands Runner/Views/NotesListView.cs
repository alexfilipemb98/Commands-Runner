﻿using Commands_Runner.Forms;
using Commands_Runner.Helpers;
using Commands_Runner.Models;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
                CreateTab(new NotesModel { Name = name });
        }

        private void CreateTab(NotesModel note)
        {
            int count = xtraTabControl.TabPages.Count + 1;

            // Create a new tab page
            XtraTabPage xtraTabPage = new XtraTabPage();
            xtraTabPage.Name = $"xtraTabPage{count}";
            xtraTabPage.Text = note.Name;
            xtraTabPage.Tag = note.Id;

            // Create a MemoEdit control
            MemoEdit memoEdit = new MemoEdit();
            memoEdit.Dock = DockStyle.Fill;
            memoEdit.Name = $"memoEdit{count}";
            memoEdit.BorderStyle = BorderStyles.NoBorder;
            memoEdit.Margin = new Padding(0);
            memoEdit.Text = note.Text;

            xtraTabPage.Controls.Add(memoEdit);

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
                    List<NotesModel> notesList = NotesModel.Get();
                    xtraTabControl.TabPages.Clear();
                    foreach (NotesModel note in notesList)
                    {
                        CreateTab(note);
                    }

                    if (showmsg)
                        AppHelper.SetStatus($"'{notesList.Count}' notes found!", Color.Green);
                }
            })
            .ContinueWith(t =>
            {
            }, TaskScheduler.FromCurrentSynchronizationContext());

        }

        private void xtraTabControl_CloseButtonClick(object sender, EventArgs e)
        {
            XtraTabPage page = xtraTabControl.SelectedTabPage;

            if (page != null)
            {
                NotesModel.DeleteFromXml(int.Parse(page.Tag.ToString()));
                xtraTabControl.TabPages.Remove(page);
            }
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) => SaveData();

        public void SaveData()
        {
            Task.Run(() =>
            {
                foreach (XtraTabPage tabPage in xtraTabControl.TabPages.ToList<XtraTabPage>())
                {
                    NotesModel note = new NotesModel();

                    note.Id = int.Parse(tabPage.Tag?.ToString());
                    note.Name = tabPage.Text;

                    foreach (var tabPageControl in tabPage.Controls)
                    {
                        if (tabPageControl is MemoEdit memo)
                            note.Text = memo.Text;
                    }

                    NotesModel.SaveToXml(note);

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
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = NotesModel.FilePath;
                saveFileDialog.Filter = "XML files (*.xml)|*.xml";
                saveFileDialog.Title = $"Export {NotesModel.FilePath}";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string destinationFilePath = saveFileDialog.FileName;
                    File.Copy(NotesModel.FilePath, destinationFilePath, overwrite: true);
                }
            }
        }

        private void bbiImport_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.FileName = NotesModel.FilePath;
                openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.Title = $"Select the source {NotesModel.FilePath} file";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourceFilePath = openFileDialog.FileName;
                    File.Copy(sourceFilePath, NotesModel.FilePath, overwrite: true);
                }
            }

            LoadData();
        }
    }
}
