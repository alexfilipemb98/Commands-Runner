using Commands_Runner.Data;
using Commands_Runner.Extensions;
using Commands_Runner.Helpers;
using Commands_Runner.Models;
using Commands_Runner.Properties;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Commands_Runner.Views
{
    public partial class SettingsView : DevExpress.XtraEditors.XtraUserControl
    {
        public SettingsView() => InitializeComponent();


        public void LoadData()
        {
            try
            {
                teSqlAddress.Text = AppHelper.Configs.SQLAddress;
                teSqlUsername.Text = AppHelper.Configs.SQLUsername;
                beSqlPassword.Text = AppHelper.Configs.SQLPassword;
                teSqlDatabase.Text = AppHelper.Configs.SQLDatabase;

                teCMDArgs.Text = AppHelper.Configs.CMDArgs;
                teCMDPath.Text = AppHelper.Configs.CMDPath;
                teCMDFileExt.Text = AppHelper.Configs.CMDFileExt;

                tePS1Args.Text = AppHelper.Configs.PS1Args;
                tePS1Path.Text = AppHelper.Configs.PS1Path;
                tePS1FileExt.Text = AppHelper.Configs.PS1FileExt;

                tePYArgs.Text = AppHelper.Configs.PYArgs;
                tePYPath.Text = AppHelper.Configs.PYPath;
                tePYFileExt.Text = AppHelper.Configs.PYFileExt;

                teHTMIMGArgs.Text = AppHelper.Configs.HTMIMGArgs;
                teHTMIMGPath.Text = AppHelper.Configs.HTMIMGPath;
                teHTMIMGFileExt.Text = AppHelper.Configs.HTMIMGFileExt;

                tsStateCommands.IsOn = AppHelper.Configs.StateCommands;
                tsStateNotes.IsOn = AppHelper.Configs.StateNotes;
                tsStatePasswords.IsOn = AppHelper.Configs.StatePasswords;
                tsStatePriExtensions.IsOn = AppHelper.Configs.StatePriExtensions;

                teHeight.Text = AppHelper.MainInstance.Height.ToString();
                teWidth.Text = AppHelper.MainInstance.Width.ToString();

                IEnumerable<NavigationPageBase> lista = AppHelper.MainInstance.navigationPaneEx.Pages.Where(w => w.PageVisible);

                cbePages.Properties.Items.Clear();

                foreach (var item in lista)
                {
                    cbePages.Properties.Items.Add(item.Caption);
                }

                cbePages.Text = AppHelper.Configs.StartUpPage;
            }
            catch (Exception ex)
            {
                AppHelper.ErrorHandler(ex);
            }
        }

        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e) =>
            SaveData();

        private void SaveData()
        {
            AppHelper.Configs.SQLAddress = teSqlAddress.Text;
            AppHelper.Configs.SQLUsername = teSqlUsername.Text;
            AppHelper.Configs.SQLPassword = beSqlPassword.Text;
            AppHelper.Configs.SQLDatabase = teSqlDatabase.Text;

            AppHelper.Configs.CMDArgs = teCMDArgs.Text;
            AppHelper.Configs.CMDPath = teCMDPath.Text;
            AppHelper.Configs.CMDFileExt = teCMDFileExt.Text;

            AppHelper.Configs.PS1Args = tePS1Args.Text;
            AppHelper.Configs.PS1Path = tePS1Path.Text;
            AppHelper.Configs.PS1FileExt = tePS1FileExt.Text;

            AppHelper.Configs.PYArgs = tePYArgs.Text;
            AppHelper.Configs.PYPath = tePYPath.Text;
            AppHelper.Configs.PYFileExt = tePYFileExt.Text;

            AppHelper.Configs.HTMIMGArgs = teHTMIMGArgs.Text;
            AppHelper.Configs.HTMIMGPath = teHTMIMGPath.Text;
            AppHelper.Configs.HTMIMGFileExt = teHTMIMGFileExt.Text;

            AppHelper.Configs.FormWidth = int.Parse(teWidth.Text);
            AppHelper.Configs.FormHeight = int.Parse(teHeight.Text);
            AppHelper.Configs.StartUpPage = cbePages.Text;

            AppHelper.Configs.StateCommands = tsStateCommands.IsOn;
            AppHelper.Configs.StateNotes = tsStateNotes.IsOn;
            AppHelper.Configs.StatePasswords = tsStatePasswords.IsOn;
            AppHelper.Configs.StatePriExtensions = tsStatePriExtensions.IsOn;

            AppHelper.MainInstance.Height = int.Parse(teHeight.Text);
            AppHelper.MainInstance.Width = int.Parse(teWidth.Text);

            AppHelper.SqlStart();
            AppHelper.SqlStausLabel();

            AppHelper.SetStatus("Settings Saved", Color.Green);

            SettingsData.Save(AppHelper.Configs);
            
            AppHelper.UpdateView();
        }

        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = "Settings.xml";
                saveFileDialog.Filter = "XML files (*.xml)|*.xml";
                saveFileDialog.Title = $"Export Settings";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string destinationFilePath = saveFileDialog.FileName;

                    SettingModel cloned = AppHelper.Configs.Clone();

                    cloned.SQLUsername = cloned.SQLUsername.Encrypt();
                    cloned.SQLAddress = cloned.SQLAddress.Encrypt();
                    cloned.SQLDatabase = cloned.SQLDatabase.Encrypt();
                    cloned.SQLPassword = cloned.SQLPassword.Encrypt();

                    string xml = AppHelper.SerializeToXml(cloned);
                    File.WriteAllText(destinationFilePath, xml);

                    AppHelper.SetStatus("Settings exported!", Color.Green);
                }
            }
        }

        private void bbiImport_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.FileName = "Settings.xml";
                    openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                    openFileDialog.Title = $"Select the source file";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string sourceFilePath = openFileDialog.FileName;
                        string xml = File.ReadAllText(sourceFilePath);
                        SettingModel root = AppHelper.DeserializeFromXml<SettingModel>(xml);

                        SettingsData.ImportToId(root, Properties.Settings.Default.SettingId);
                        AppHelper.Configs = root;

                        AppHelper.MainInstance.Height = AppHelper.Configs.FormHeight;
                        AppHelper.MainInstance.Width = AppHelper.Configs.FormWidth;
                    }
                }

                LoadData();
            }
            catch (Exception ex)
            {
                AppHelper.ErrorHandler(ex);
            }
        }

        private void sbResetSize_Click(object sender, EventArgs e)
        {
            AppHelper.MainInstance.Size = new Size(1000, 530);
        }

        private void sbGetDatabases_Click(object sender, EventArgs e)
        {
            teSqlDatabase.Properties.Items.Clear();

            dxErrorProvider.ClearErrors();

            if (string.IsNullOrWhiteSpace(teSqlAddress.Text))
                dxErrorProvider.SetError(teSqlAddress, "Address is required!");

            if (string.IsNullOrWhiteSpace(teSqlUsername.Text))
                dxErrorProvider.SetError(teSqlUsername, "Username is required!");

            if (string.IsNullOrWhiteSpace(beSqlPassword.Text))
                dxErrorProvider.SetError(beSqlPassword, "Password is required!");

            if (dxErrorProvider.HasErrors)
                return;

            if (AppHelper.SqlStart(teSqlAddress.Text, teSqlUsername.Text, beSqlPassword.Text) && AppHelper.SqlStausLabel())
            {
                string sql = "SELECT name FROM master.dbo.sysdatabases";
                List<string> lista = AppHelper.SQL.LoadDataListOpen<string>(sql);

                teSqlDatabase.Properties.Items.AddRange(lista);
                teSqlDatabase.Properties.DropDownRows = Math.Min(lista.Count, 7);
            }
            else
            {
                XtraMessageBox.Show("Could not connect to database!", "Connection ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                teSqlDatabase.Properties.Items.Clear();
                teSqlDatabase.Properties.DropDownRows = 0;
            }
        }

        private void beSqlPassword_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            bool usePasswordChar = beSqlPassword.Properties.UseSystemPasswordChar;
            beSqlPassword.Properties.UseSystemPasswordChar = !usePasswordChar;

            beSqlPassword.Properties.Buttons[0].ImageOptions.SvgImage = usePasswordChar
                ? Resources.security_visibility
                : Resources.security_visibilityoff;
        }
    }
}
