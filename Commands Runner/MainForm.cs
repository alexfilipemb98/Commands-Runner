using Commands_Runner.Data;
using Commands_Runner.Forms;
using Commands_Runner.Helpers;
using Commands_Runner.Models;
using Commands_Runner.Properties;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using Life_Log.Components;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commands_Runner
{
    public partial class MainForm : RibbonForm
    {
        #region MAIN

        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            LoadSettings();

            bsiVersion.Caption = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            bsiSizse.Caption = $"Size: {Size.Width} X {Size.Height}";
        }

        /// <summary>
        /// TImer to only display time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            bsiTime.Caption = $"{DateTime.Now:yyyy/MM/dd HH:mm:ss}";
        }

        /// <summary>
        /// Resize update label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Resize(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                if (this.InvokeRequired)
                {
                    this.Invoke((MethodInvoker)(() =>
                    {
                        bsiSizse.Caption = $"Size: {Size.Width} X {Size.Height}";
                        settingsView.teHeight.Text = Size.Height.ToString();
                        settingsView.teWidth.Text = Size.Width.ToString();
                    }));
                }
                else
                {
                    bsiSizse.Caption = $"Size: {Size.Width} X {Size.Height}";
                    settingsView.teHeight.Text = Size.Height.ToString();
                    settingsView.teWidth.Text = Size.Width.ToString();
                }
            });
        }

        /// <summary>
        /// Closing form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Do you really want to exit?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    e.Cancel = true;

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                SettingsData.UpdateGeneralSettings(Properties.Settings.Default.SettingId, this.Height, this.Width, this.WindowState);

                config.AppSettings.Settings[nameof(CommandFilterModel.ShowDisabled)].Value = AppHelper.CommandsFilters.ShowDisabled.ToString();
                config.AppSettings.Settings[nameof(CommandFilterModel.ShowCMD)].Value = AppHelper.CommandsFilters.ShowCMD.ToString();
                config.AppSettings.Settings[nameof(CommandFilterModel.ShowPS1)].Value = AppHelper.CommandsFilters.ShowPS1.ToString();
                config.AppSettings.Settings[nameof(CommandFilterModel.ShowPY)].Value = AppHelper.CommandsFilters.ShowPY.ToString();
                config.Save(ConfigurationSaveMode.Modified);

                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (Exception ex)
            {
                AppHelper.ErrorHandler(ex);
            }
        }

        #endregion

        #region CLICK

        /// <summary>
        /// Show the three simple rule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiThreeSimpleRule_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (ThreeSimpleRuleForm form = new ThreeSimpleRuleForm())
            {
                form.ShowDialog();
            }
        }

        #endregion

        #region FUNCTIONS

        /// <summary>
        /// Loads the form size
        /// </summary>
        private void LoadSettings()
        {
            AppHelper.CommandsFilters = new CommandFilterModel();

            if (bool.TryParse(ConfigurationManager.AppSettings[nameof(CommandFilterModel.ShowDisabled)], out bool showdisabled))
            {
                AppHelper.CommandsFilters.ShowDisabled = showdisabled;
                commandsListView.btsiShowDisabled.Checked = showdisabled;
            }

            if (bool.TryParse(ConfigurationManager.AppSettings[nameof(CommandFilterModel.ShowCMD)], out bool showcmd))
            {
                AppHelper.CommandsFilters.ShowCMD = showcmd;
                commandsListView.btsiFilterCmd.Checked = showcmd;
            }

            if (bool.TryParse(ConfigurationManager.AppSettings[nameof(CommandFilterModel.ShowPS1)], out bool showps1))
            {
                AppHelper.CommandsFilters.ShowPS1 = showps1;
                commandsListView.btsiFilterPs1.Checked = showps1;
            }

            if (bool.TryParse(ConfigurationManager.AppSettings[nameof(CommandFilterModel.ShowPY)], out bool showpy))
            {
                AppHelper.CommandsFilters.ShowPY = showpy;
                commandsListView.btsiFilterPy.Checked = showpy;
            }
        }

        #endregion

        private void bbiConverterHtmPNG_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                folderBrowser.Description = "Choose the path to HTM content";
                folderBrowser.ShowNewFolderButton = false;
                folderBrowser.RootFolder = Environment.SpecialFolder.Desktop;

                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolder = folderBrowser.SelectedPath;
                    ConvertHtmlFilesToPng(selectedFolder);
                }
            }
        }

        private void ConvertHtmlFilesToPng(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                AppHelper.SetStatus("Folder not found!", Color.Red);
                return;
            }

            string[] files = Directory.GetFiles(folderPath, "*.htm")
                          .OrderBy(f => File.GetCreationTime(f))
                          .ToArray();

            if (string.IsNullOrWhiteSpace(AppHelper.Configs.HTMIMGPath) ||
                string.IsNullOrWhiteSpace(AppHelper.Configs.HTMIMGFileExt))
            {
                AppHelper.SetStatus("Not Configured", Color.Red);
                return;
            }

            Task.Run(() =>
            {

                string PastaDeConversao = Path.Combine(folderPath, "Converted Files");

                if (!Directory.Exists(PastaDeConversao))
                    Directory.CreateDirectory(PastaDeConversao);


                int count = 1;
                foreach (var file in files)
                {
                    string fileExtension = AppHelper.Configs.HTMIMGFileExt.Replace(".", string.Empty);
                    string outputFileName = Path.Combine(PastaDeConversao, Path.GetFileNameWithoutExtension(file) + fileExtension);

                    if (File.Exists(outputFileName))
                        continue;

                    ProcessStartInfo StartInfo = new ProcessStartInfo
                    {
                        FileName = AppHelper.Configs.HTMIMGPath,
                        Arguments = $"{AppHelper.Configs.HTMIMGArgs} {file} {outputFileName}",
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    StartInfo.Verb = "runas";

                    Process process = new Process
                    {
                        StartInfo = StartInfo
                    };

                    process.Start();
                    process.WaitForExit();

                    Invoke((MethodInvoker)(() =>
                    {
                        if (File.Exists(outputFileName))
                            AppHelper.SetStatus($"Created Image: {Path.GetFileName(outputFileName)} ({count} of {files.Length})", Color.Green);
                        else
                            AppHelper.SetStatus($"Failed Image: {Path.GetFileName(file)} ({count} of {files.Length})", Color.Red);

                    }));

                    count++;
                }
            }).ContinueWith(t =>
            {
                AppHelper.SetStatus($"Converted {files.Length} images", Color.Red);
            });
        }

        private void navigationPaneEx_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
        {
            if (e.Page == npCommandsListView)
                commandsListView.LoadData();
            else if (e.Page == npPrimaveraExtensions)
                priExtensionsListView1.LoadData();
            else if (e.Page == npPasswordsListView)
                passwordsListView.LoadData();
            else if (e.Page == npSettingsView)
                settingsView.LoadData();
            else if (e.Page == npNoteView)
                notesView.LoadData();

            if (e.Page != npNoteView && e.OldPage == npNoteView)
                notesView.SaveData();

            if (e.Page == navigationPage1)
                tasksView1.DemoData();
        }

        private void btsSetTopMost_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            this.TopMost = btsSetTopMost.Checked;
        }
    }
}
