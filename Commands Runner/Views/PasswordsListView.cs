using Commands_Runner.Helpers;
using Commands_Runner.Models;
using Commands_Runner.Properties;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commands_Runner.Views
{
    public partial class PasswordsListView : DevExpress.XtraEditors.XtraUserControl
    {
        public PasswordsListView()
        {
            InitializeComponent();
        }

        private void btsEditModePasswords_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            gvPasswords.OptionsBehavior.ReadOnly = !btsEditModePasswords.Checked;
            gvPasswords.OptionsView.NewItemRowPosition = btsEditModePasswords.Checked ? NewItemRowPosition.Top : NewItemRowPosition.None;
            ribActionsPasswords.Buttons[1].Visible = btsEditModePasswords.Checked;
            gvPasswords.Columns[4].OptionsColumn.AllowEdit = true;
            colPasswordsUsername.OptionsColumn.AllowFocus = btsEditModePasswords.Checked;
            colPasswordsName.OptionsColumn.AllowFocus = btsEditModePasswords.Checked;
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Tag?.ToString() == "ShowPassword")
            {
                var gridView = gcPasswords.FocusedView as DevExpress.XtraGrid.Views.Grid.GridView;
                if (gridView == null) return;

                // Obter o editor ativo
                var activeEditor = gridView.ActiveEditor as DevExpress.XtraEditors.ButtonEdit;
                if (activeEditor == null) return;

                // Alternar o estado diretamente no editor ativo
                bool usePasswordChar = activeEditor.Properties.UseSystemPasswordChar;
                activeEditor.Properties.UseSystemPasswordChar = !usePasswordChar;

                // Alterar a imagem do botão no editor ativo
                activeEditor.Properties.Buttons[0].ImageOptions.SvgImage = usePasswordChar
                    ? Resources.security_visibility
                    : Resources.security_visibilityoff;
            }
        }

        private void gvPasswords_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (e.Row is PasswordsModel pp && pp != null)
            {
                PasswordsModel.SaveToXml(pp);
                AppHelper.SetStatus("Password saved!", Color.Green);
            }
        }

        private void gvPasswords_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName == colPassword.Name)
            {
                RepositoryItemButtonEdit clonedRepo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
                clonedRepo.Assign(repositoryItemButtonEdit1);
                clonedRepo.UseSystemPasswordChar = true;
                clonedRepo.Buttons[0].ImageOptions.SvgImage = Resources.security_visibility;
                e.RepositoryItem = clonedRepo;
            }
        }

        private void repositoryItemButtonEdit2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvPasswords.GetFocusedRow() is PasswordsModel passwordsModel)
            {
                if (e.Button.Tag?.ToString() == "DEL")
                {
                    var result = XtraMessageBox.Show($"Do you realy want to delete '{passwordsModel.Name}'?", "Delete password", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        PasswordsModel.DeleteFromXml(passwordsModel.Id);
                        AppHelper.SetStatus("Password deleted!", Color.Red);
                        passwordsModelBindingSource.Remove(passwordsModel);
                    }
                }
                else if (e.Button.Tag?.ToString() == "COPY")
                {
                    Clipboard.SetText(passwordsModel.Password);
                    AppHelper.SetStatus("Password copied to clipboard!", Color.Green);
                }
            }
        }

        /// <summary>
        /// Load Passwords to list
        /// </summary>
        public void LoadData(bool showmsg = true)
        {
            gvPasswords.BeginDataUpdate();
            gvPasswords.ShowLoadingPanel();

            Task.Run(() =>
            {
                if (this.InvokeRequired)
                    this.Invoke((MethodInvoker)(() => ld()));
                else
                    ld();

                void ld()
                {
                    List<PasswordsModel> passwords = PasswordsModel.Get();
                    passwordsModelBindingSource.DataSource = passwords;

                    if (showmsg)
                    {
                        AppHelper.SetStatus($"'{passwords.Count}' passwords found!", Color.Green);
                    }
                }
            })
            .ContinueWith(t =>
            {
                gvPasswords.EndDataUpdate();
                gvPasswords.HideLoadingPanel();
            }, TaskScheduler.FromCurrentSynchronizationContext());

        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e) => LoadData();

        private void bbiExportPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = "PasswordsList.pdf";
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Export Passwords.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string destinationFilePath = saveFileDialog.FileName;

                    gvPasswords.ExportToPdf(destinationFilePath);
                }
            }

        }

        private void bbiExportExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = "PasswordsList.xls";
                saveFileDialog.Filter = "XLS Files (*.xls)|*.xls";
                saveFileDialog.Title = "Export Passwords.xls";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string destinationFilePath = saveFileDialog.FileName;

                    gvPasswords.ExportToXls(destinationFilePath);
                }
            }
        }
    }
}
