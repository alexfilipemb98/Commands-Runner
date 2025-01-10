using Commands_Runner.Helpers;
using Commands_Runner.Properties;
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

            teHeight.Text = AppHelper.Instance.Height.ToString();
            teWidth.Text = AppHelper.Instance.Width.ToString();

        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

            AppHelper.Instance.Height = int.Parse(teHeight.Text);
            AppHelper.Instance.Width = int.Parse(teWidth.Text);

            AppHelper.SqlStart();
            AppHelper.SqlStausLabel();

            AppHelper.SetStatus("Settings Saved", Color.Green);

            ConfigsModel.SaveToFile(AppHelper.Configs);
        }

        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = ConfigsModel.FilePath;
                saveFileDialog.Filter = "XML files (*.xml)|*.xml";
                saveFileDialog.Title = $"Export {ConfigsModel.FilePath}";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string destinationFilePath = saveFileDialog.FileName;

                    File.Copy(ConfigsModel.FilePath, destinationFilePath, overwrite: true);

                    AppHelper.SetStatus("Settings exported!", Color.Green);
                }
            }
        }

        private void bbiImportCommands_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.FileName = ConfigsModel.FilePath;
                openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.Title = $"Select the source {ConfigsModel.FilePath} file";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourceFilePath = openFileDialog.FileName;
                    File.Copy(sourceFilePath, ConfigsModel.FilePath, overwrite: true);
                }
            }

            AppHelper.Configs = ConfigsModel.ReadFile(out _);
            AppHelper.Instance.Height = AppHelper.Configs.FormHeight;
            AppHelper.Instance.Width = AppHelper.Configs.FormWidth;
            LoadData();
        }

        private void sbResetSize_Click(object sender, EventArgs e)
        {
            AppHelper.Instance.Size = new Size(1000, 530);
        }

        private void sbGetDatabases_Click(object sender, EventArgs e)
        {
            teSqlDatabase.Properties.Items.Clear();

            AppHelper.SqlStart();
            if (AppHelper.SqlStausLabel())
            {
                string sql = "SELECT name FROM master.dbo.sysdatabases";
                List<string> lista = AppHelper.SQL.LoadDataListOpen<string>(sql);

                teSqlDatabase.Properties.Items.AddRange(lista);
                teSqlDatabase.Properties.DropDownRows = Math.Min(lista.Count, 7);
            }
            else
            {
                XtraMessageBox.Show("Could not connect to database!", "Connection ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
