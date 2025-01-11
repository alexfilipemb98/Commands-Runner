using Commands_Runner.Forms;
using Commands_Runner.Helpers;
using Commands_Runner.Models;
using Commands_Runner.Properties;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Tile;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commands_Runner.Views
{
    public partial class CommandsListView : DevExpress.XtraEditors.XtraUserControl
    {
        private CommandsModel command;

        public CommandsListView() => InitializeComponent();

        #region CLICK

        /// <summary>
        /// New command
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (CommandsEditorForm.Show(new CommandsModel() { Enabled = true }) == DialogResult.OK)
            {
                AppHelper.SetStatus($"Command was been created!", Color.Green);
                LoadData(false);
            }
        }

        /// <summary>
        /// Edit command
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (command != null && CommandsEditorForm.Show(command) == DialogResult.OK)
            {
                AppHelper.SetStatus($"Command was been updated!", Color.Green);
                LoadData(false);
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
                    AppHelper.SetStatus($"Command was been deleted!", Color.Red);

                    LoadData(false);
                }
            }
        }

        /// <summary>
        /// Enables or disables the passwords!
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
                    AppHelper.SetStatus($"Command was been disabled!", Color.Red);
                }
                else
                {

                    command.Enabled = true;
                    AppHelper.SetStatus($"Command was been enabled!", Color.Green);
                }
            }

            CommandsModel.UpdateEnabledPropertyInXml(command);

            LoadData(false);
        }

        /// <summary>
        /// Refresh the grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e) => LoadData();

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
                this.BringToFront();
            }
        }

        /// <summary>
        /// Export passwords
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = CommandsModel.FilePath;
                saveFileDialog.Filter = "XML files (*.xml)|*.xml";
                saveFileDialog.Title = $"Export {CommandsModel.FilePath}";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string destinationFilePath = saveFileDialog.FileName;

                    File.Copy(CommandsModel.FilePath, destinationFilePath, overwrite: true);
                }
            }
        }

        /// <summary>
        /// Import passwords
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiImportCommands_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.FileName = CommandsModel.FilePath;
                openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.Title = $"Select the source {CommandsModel.FilePath} file";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourceFilePath = openFileDialog.FileName;
                    File.Copy(sourceFilePath, CommandsModel.FilePath, overwrite: true);
                }
            }

            LoadData();
        }

        /// <summary>
        /// Command to file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiCreateFile_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (command != null)
                CommandsModel.SaveCommandToFile(command.Type, command.Command, command.Name);
        }

        #endregion

        #region TV COMMANDS

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
                this.BringToFront();
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
                bbiEdit.Visibility = BarItemVisibility.Never;
                bbiDelete.Visibility = BarItemVisibility.Never;
                bbiEnabled.Visibility = BarItemVisibility.Never;
                bbiRunAdmin.Visibility = BarItemVisibility.Never;

                popupMenu.ShowPopup(Control.MousePosition);
            }
        }

        /// <summary>
        /// Grid right click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvCommands_ItemRightClick(object sender, TileViewItemClickEventArgs e)
        {
            command = GetObjectByRowHandle(e.Item.RowHandle);

            bbiEdit.Visibility = BarItemVisibility.Always;
            bbiDelete.Visibility = BarItemVisibility.Always;
            bbiEnabled.Visibility = BarItemVisibility.Always;
            bbiEnabled.Caption = command.Enabled ? "Disable" : "Enable";
            bbiEnabled.ImageOptions.SvgImage = command.Enabled ? Resources.actions_checkcircled : Resources.actions_deletecircled;
            bbiRunAdmin.Visibility = BarItemVisibility.Always;

            popupMenu.ShowPopup(Control.MousePosition);
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

                if (data.Type == Enums.CommandTypeEnum.CMD)
                    data.Icon = Resources.window_terminal;
                else if (data.Type == Enums.CommandTypeEnum.PS1)
                    data.Icon = Resources.powershell;
                else if (data.Type == Enums.CommandTypeEnum.PY)
                    data.Icon = Resources.python;
            }
        }

        /// <summary>
        /// Item start drag
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvCommands_ItemDrag(object sender, DevExpress.XtraGrid.Views.Tile.ItemDragEventArgs e)
        {
            command = GetObjectByRowHandle(e.RowHandle);
        }

        /// <summary>
        /// Item drop "Ended"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvCommands_ItemDrop(object sender, ItemDropEventArgs e)
        {
            Task.Run(async () =>
            {
                await Task.Delay(1500);

                for (int i = 0; i < tvCommands.RowCount; i++)
                {
                    int rowHandle = tvCommands.GetRowHandle(i);

                    if (tvCommands.GetRow(rowHandle) is CommandsModel command)
                    {
                        command.Position = i;
                        CommandsModel.UpdatePositionPropertyInXml(command);
                    }
                }
            });

            AppHelper.SetStatus($"Command '{e.RowHandle}' moved!", Color.Green);
        }

        #endregion

        #region CHECKED CHANGED

        private void btsiShowDisabled_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            AppHelper.CommandsFilters.ShowDisabled = btsiShowDisabled.Checked;
            LoadData();
        }

        private void btsiFilterCmd_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            AppHelper.CommandsFilters.ShowCMD = btsiFilterCmd.Checked;
            LoadData();
        }

        private void btsiFilterPs1_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            AppHelper.CommandsFilters.ShowPS1 = btsiFilterPs1.Checked;
            LoadData();
        }

        private void btsiFilterPy_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            AppHelper.CommandsFilters.ShowPY = btsiFilterPy.Checked;
            LoadData();
        }

        #endregion

        #region FUNCTIONS

        /// <summary>
        /// Load Commands to list
        /// </summary>
        public void LoadData(bool showmsg = true)
        {
            tvCommands.BeginDataUpdate();

            Task.Run(() =>
            {
                if (this.InvokeRequired)
                    this.Invoke((MethodInvoker)(() => ld()));
                else
                    ld();

                void ld()
                {
                    List<CommandsModel> commands = CommandsModel.Get(AppHelper.CommandsFilters);
                    commandsModelBindingSource.DataSource = commands;

                    if (showmsg)
                        AppHelper.SetStatus($"'{commands.Count}' commands found!", Color.Green);
                }
            })
            .ContinueWith(t =>
            {
                tvCommands.EndDataUpdate();
            }, TaskScheduler.FromCurrentSynchronizationContext());

        }

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
            string fileExtension = string.Empty;

            try
            {
                if (!file.Enabled)
                {
                    AppHelper.SetStatus("Command is disabled!", Color.Red);
                    return Task.CompletedTask;
                }

                batchFilePath = Path.Combine("Temp", $"temp_{Guid.NewGuid()}");

                if (!Directory.Exists(Path.GetDirectoryName(batchFilePath)))
                    Directory.CreateDirectory(Path.GetDirectoryName(batchFilePath));

                if (file.Type == Enums.CommandTypeEnum.CMD)
                {
                    fileExtension = AppHelper.Configs.CMDFileExt.Replace(".", string.Empty);
                    batchFilePath += $".{AppHelper.Configs.CMDFileExt}";
                    fileName = AppHelper.Configs.CMDPath;
                    arguments = $"{AppHelper.Configs.CMDArgs} {batchFilePath}";

                    //batchFilePath += ".bat";
                    //fileName = "cmd.exe";
                    //arguments = $"/C \"{batchFilePath}\"";
                }
                else if (file.Type == Enums.CommandTypeEnum.PS1)
                {
                    fileExtension = AppHelper.Configs.PS1FileExt.Replace(".", string.Empty);
                    batchFilePath += $".{AppHelper.Configs.PS1FileExt}";
                    fileName = AppHelper.Configs.PS1Path;
                    arguments = $"{AppHelper.Configs.PS1Args} {batchFilePath}";

                    //batchFilePath += ".ps1";
                    //fileName = "powershell.exe";
                    //arguments = $"-ExecutionPolicy Bypass -File \"{batchFilePath}\"";
                }
                else if (file.Type == Enums.CommandTypeEnum.PY)
                {
                    fileExtension = AppHelper.Configs.PYFileExt.Replace(".", string.Empty);
                    batchFilePath += $".{AppHelper.Configs.PYFileExt}";
                    fileName = AppHelper.Configs.PYPath;
                    arguments = $"{AppHelper.Configs.PYArgs} {batchFilePath}";

                    //batchFilePath += ".py";
                    //fileName = "py";
                    //arguments = $" \"{batchFilePath}\"";
                }
                else
                {
                    AppHelper.SetStatus("Command not supported!", Color.Red);
                    return Task.CompletedTask;
                }

                Encoding utf8WithBom = new UTF8Encoding(encoderShouldEmitUTF8Identifier: true);

                File.WriteAllText(batchFilePath, file.Command, utf8WithBom);

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = fileName,
                    Arguments = arguments,
                    UseShellExecute = true,
                    CreateNoWindow = false,
                };

                if (runInAdmin)
                {
                    startInfo.Verb = "runas";
                }

                Process process = new Process
                {
                    StartInfo = startInfo
                };

                process.Start();
                process.WaitForExit();

                AppHelper.SetStatus($"Command '{file.Name}' executed!", Color.Green);
            }
            catch (Exception)
            {
                AppHelper.SetStatus($"Problem executing the command!", Color.Red);
            }
            finally
            {
                if (File.Exists(batchFilePath))
                    File.Delete(batchFilePath);

                AppHelper.Instance.BringToFront();
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

    }
}
