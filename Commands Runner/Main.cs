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
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
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

        /// <summary>
        /// Tiles click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvCommands_ItemClick(object sender, TileViewItemClickEventArgs e)
        {
            int rowIndex = e.Item.RowHandle;
            if (rowIndex >= 0)
            {
                CommandsModel rowData = tvCommands.GetRow(rowIndex) as CommandsModel;

                if (rowData != null)
                {
                    ExecuteFile(rowData).Wait();
                    Thread.Sleep(200);
                    Program.BringToFront(this.Text);
                }

            }
        }

        /// <summary>
        /// New command
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Editor.Show(new CommandsModel()) == DialogResult.OK)
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
        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Editor.Show(command) == DialogResult.OK)
            {
                bsiStatus.ItemAppearance.Normal.ForeColor = Color.Green;
                bsiStatus.Caption = $"Commnand was been updated!";
            }
        }

        /// <summary>
        /// Delete command
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
        /// Refresh the grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            commandsModelBindingSource.DataSource = CommandsModel.Get();
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
                bbiEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                bbiDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
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
            bbiEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            bbiDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            popupMenu.ShowPopup(p2);

            int rowIndex = e.Item.RowHandle;
            if (rowIndex >= 0)
            {
                command = tvCommands.GetRow(rowIndex) as CommandsModel;
            }
        }

        /// <summary>
        /// Execute File
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        private Task ExecuteFile(CommandsModel file)
        {
            string batchFilePath = string.Empty;
            string fileName = string.Empty;
            string arguments = string.Empty;

            try
            {
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
                    arguments = $"-ExecutionPolicy Bypass -File \"{batchFilePath}\""; // Permite a execução de scripts sem restrições
                }
                else
                {
                    bsiStatus.ItemAppearance.Normal.ForeColor = Color.Red;
                    bsiStatus.Caption = "Command not supported.";
                    return Task.CompletedTask;
                }

                File.WriteAllText(batchFilePath, file.Command);

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = fileName,
                    Arguments = arguments,
                    UseShellExecute = true,
                    CreateNoWindow = false // Cria uma nova janela
                };

                Process process = new Process
                {
                    StartInfo = startInfo
                };

                process.Start();
                process.WaitForExit(); // Aguarda o processo terminar

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
        /// TImer to only display time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            bsiTime.Caption = $"Time: {DateTime.Now:yyyy/MM/dd HH:mm:ss}";
        }

    }
}
