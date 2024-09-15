using Commands_Runner.Properties;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Tile;
using DevExpress.XtraRichEdit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commands_Runner
{
    public partial class Main : RibbonForm
    {
        private CommandsModel command;

        /// <summary>
        /// Constructor
        /// </summary>
        public Main()
        {
            InitializeComponent();

            List<CommandsModel> commands = CommandsModel.Get();
            commandsModelBindingSource.DataSource = commands;

            bsiStatus.Caption = $"'{commands.Count}' commands found!";
            bsiVersion.Caption = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        #region CLICK

        /// <summary>
        /// Tiles click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvCommands_ItemClick(object sender, TileViewItemClickEventArgs e)
        {
            CommandsModel rowData = GetObjectByRowHandle(e.Item.RowHandle);

            if (rowData != null)
            {
                ExecuteFile(rowData).Wait();
                Thread.Sleep(200);
                Program.BringToFront(this.Text);
            }
        }

        /// <summary>
        /// New command
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Editor.Show(new CommandsModel() { Enabled = true }) == DialogResult.OK)
            {
                bsiStatus.ItemAppearance.Normal.ForeColor = Color.Green;
                bsiStatus.Caption = $"Commnand was been created!";

                commandsModelBindingSource.DataSource = CommandsModel.Get();
            }
        }

        /// <summary>
        /// Edit command
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (command != null && Editor.Show(command) == DialogResult.OK)
            {
                bsiStatus.ItemAppearance.Normal.ForeColor = Color.Green;
                bsiStatus.Caption = $"Commnand was been updated!";
                commandsModelBindingSource.DataSource = CommandsModel.Get();
            }
        }

        /// <summary>
        /// Delete command
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (command != null)
            {
                DialogResult result = XtraMessageBox.Show($"Do you want to delete '{command.Name}'", "Delete command", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    CommandsModel.DeleteFromXml(command.Id);

                    bsiStatus.ItemAppearance.Normal.ForeColor = Color.Red;
                    bsiStatus.Caption = $"Commnand was been deleted!";

                    commandsModelBindingSource.DataSource = CommandsModel.Get();
                }
            }
        }

        /// <summary>
        /// Enables or disables the commands!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiEnabled_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (command != null)
            {
                if (command.Enabled)
                {
                    command.Enabled = false;
                    bsiStatus.ItemAppearance.Normal.ForeColor = Color.Red;
                    bsiStatus.Caption = $"Commnand was been disabled!";
                }
                else
                {

                    command.Enabled = true;
                    bsiStatus.ItemAppearance.Normal.ForeColor = Color.Green;
                    bsiStatus.Caption = $"Commnand was been enabled!";
                }
            }

            CommandsModel.UpdateEnabledPropertyInXml(command);

            commandsModelBindingSource.DataSource = CommandsModel.Get();
        }

        /// <summary>
        /// Refresh the grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            List<CommandsModel> commands = CommandsModel.Get();
            commandsModelBindingSource.DataSource = commands;
            bsiStatus.ItemAppearance.Normal.Reset();
            bsiStatus.Caption = $"Reloaded list, '{commands.Count}' commands found!";
        }

        /// <summary>
        /// Run command in admin mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiRunAdmin_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (command != null)
            {
                ExecuteFile(command, true).Wait();
                Thread.Sleep(200);
                Program.BringToFront(this.Text);
            }
        }

        /// <summary>
        /// Empty space click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvCommands_Click(object sender, EventArgs e)
        {
            if (((MouseEventArgs)e).Button == MouseButtons.Right)
            {
                Point p2 = Control.MousePosition;
                bbiEdit.Visibility = BarItemVisibility.Never;
                bbiDelete.Visibility = BarItemVisibility.Never;
                bbiEnabled.Visibility = BarItemVisibility.Never;
                bbiRunAdmin.Visibility = BarItemVisibility.Never;
                popupMenu.ShowPopup(p2);
            }
        }

        /// <summary>
        /// Grid right click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvCommands_ItemRightClick(object sender, TileViewItemClickEventArgs e)
        {
            Point p2 = Control.MousePosition;
            bbiEdit.Visibility = BarItemVisibility.Always;
            bbiDelete.Visibility = BarItemVisibility.Always;
            bbiEnabled.Visibility = BarItemVisibility.Always;
            bbiRunAdmin.Visibility = BarItemVisibility.Always;
            popupMenu.ShowPopup(p2);
            command = GetObjectByRowHandle(e.Item.RowHandle);
            bbiEnabled.Caption = command.Enabled ? "Disable" : "Enable";
        }

        #endregion

        #region FUNCTIONS

        /// <summary>
        /// Execute File
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        private Task ExecuteFile(CommandsModel file, bool runInAdmin = false)
        {
            string batchFilePath = string.Empty;
            string fileName = string.Empty;
            string arguments = string.Empty;

            try
            {
                if (!file.Enabled)
                {
                    bsiStatus.ItemAppearance.Normal.ForeColor = Color.Red;
                    bsiStatus.Caption = "Command is disabled!";
                    return Task.CompletedTask;
                }

                if (file.Type.Equals("cmd"))
                {
                    batchFilePath = Path.Combine(Path.GetTempPath(), $"temp_{Guid.NewGuid()}.bat");
                    fileName = "cmd.exe";
                    arguments = $"/C \"{batchFilePath}\"";
                }
                else if (file.Type.Equals("ps1"))
                {
                    batchFilePath = Path.Combine(Path.GetTempPath(), $"temp_{Guid.NewGuid()}.ps1");
                    fileName = "powershell.exe";
                    arguments = $"-ExecutionPolicy Bypass -File \"{batchFilePath}\""; // Allow script execution without restrictions
                }
                else
                {
                    bsiStatus.ItemAppearance.Normal.ForeColor = Color.Red;
                    bsiStatus.Caption = "Command not supported!";
                    return Task.CompletedTask;
                }

                File.WriteAllText(batchFilePath, file.Command);

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = fileName,
                    Arguments = arguments,
                    UseShellExecute = true,
                    CreateNoWindow = false, // Create a new window
                };

                // If RunInAdmin is true, set the Verb to "runas" to prompt for admin privileges
                if (runInAdmin)
                {
                    startInfo.Verb = "runas";
                }

                Process process = new Process
                {
                    StartInfo = startInfo
                };

                process.Start();
                process.WaitForExit(); // Wait for the process to complete

                bsiStatus.ItemAppearance.Normal.ForeColor = Color.Green;
                bsiStatus.Caption = $"Command '{file.Name}' executed!";
            }
            catch (Exception ex)
            {
                bsiStatus.ItemAppearance.Normal.ForeColor = Color.Red;
                bsiStatus.Caption = "Problem executing the command: " + ex.ToString();
            }
            finally
            {
                if (File.Exists(batchFilePath))
                    File.Delete(batchFilePath);

                this.BringToFront();
            }

            return Task.CompletedTask;
        }

        /// <summary>
        /// Gets the object by row handle
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <returns></returns>
        private CommandsModel GetObjectByRowHandle(int rowIndex)
        {
            if (rowIndex >= 0)
                return tvCommands.GetRow(rowIndex) as CommandsModel;
            else
                return null;
        }

        #endregion

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
        /// Template
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvCommands_CustomItemTemplate(object sender, TileViewCustomItemTemplateEventArgs e)
        {
            CommandsModel data = GetObjectByRowHandle(e.RowHandle);

            if (data != null)
            {
                if (data.Enabled)
                    e.HtmlTemplate.Template = e.HtmlTemplate.Template.Replace("@@classEnabled@@", "cardBorderEnabled");
                else
                    e.HtmlTemplate.Template = e.HtmlTemplate.Template.Replace("@@classEnabled@@", "cardBorderDisabled");

                if (data.Type == "cmd")
                    data.Icon = Resources.window_terminal;
                else if (data.Type == "ps1")
                    data.Icon = Resources.powershell;
            }
        }

    }
}
