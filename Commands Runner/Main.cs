using Commands_Runner.Forms;
using Commands_Runner.Models;
using Commands_Runner.Properties;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Tile;
using IronPython.Runtime;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commands_Runner
{
	public partial class Main : RibbonForm
	{
		#region MAIN

		/*Variaveis*/

		private CommandsModel command;
		private CommandFilterModel filters;

		/// <summary>
		/// Constructor
		/// </summary>
		public Main()
		{
			InitializeComponent();

			LoadSettings();

			LoadCommands();
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
					}));
				}
				else
				{
					bsiSizse.Caption = $"Size: {Size.Width} X {Size.Height}";
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
			Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

			config.AppSettings.Settings["FormWidth"].Value = this.Width.ToString();
			config.AppSettings.Settings["FormHeight"].Value = this.Height.ToString();

			config.AppSettings.Settings[nameof(CommandFilterModel.ShowDisabled)].Value = filters.ShowDisabled.ToString();
			config.AppSettings.Settings[nameof(CommandFilterModel.ShowCMD)].Value = filters.ShowCMD.ToString();
			config.AppSettings.Settings[nameof(CommandFilterModel.ShowPS1)].Value = filters.ShowPS1.ToString();
			config.AppSettings.Settings[nameof(CommandFilterModel.ShowPY)].Value = filters.ShowPY.ToString();

			config.Save(ConfigurationSaveMode.Modified);
			ConfigurationManager.RefreshSection("appSettings");
		}

		#endregion

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
			if (CommandsEditorForm.Show(new CommandsModel() { Enabled = true }) == DialogResult.OK)
			{
				bsiStatus.ItemAppearance.Normal.ForeColor = Color.Green;
				bsiStatus.Caption = $"Commnand was been created!";

				LoadCommands(false);
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
				bsiStatus.ItemAppearance.Normal.ForeColor = Color.Green;
				bsiStatus.Caption = $"Commnand was been updated!";

				LoadCommands(false);
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

					LoadCommands(false);
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

			LoadCommands(false);
		}

		/// <summary>
		/// Refresh the grid
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e) => LoadCommands();

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
		/// Export passwords
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bbiExport_ItemClick(object sender, ItemClickEventArgs e)
		{
			string sourceFilePath = @"commands.xml"; // Replace this with the actual path of passwords.xml

			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.FileName = "commands.xml"; // Default file name
				saveFileDialog.Filter = "XML files (*.xml)|*.xml"; // Filter for XML files
				saveFileDialog.Title = "Export commands.xml";

				// Show SaveFileDialog and check if the user selected a file
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					string destinationFilePath = saveFileDialog.FileName;

					System.IO.File.Copy(sourceFilePath, destinationFilePath, overwrite: true);
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
			// Step 1: Ask the user to select the source file
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.FileName = "commands.xml"; // Suggest default file name
				openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"; // Filter for XML files
				openFileDialog.Title = "Select the source commands.xml file";

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					string sourceFilePath = openFileDialog.FileName;

					// Copy the file to the destination
					System.IO.File.Copy(sourceFilePath, "commands.xml", overwrite: true);

				}
			}

			bbiRefresh_ItemClick(sender, e);
		}

		/// <summary>
		/// Reset form size
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bbiResetFormSize_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Size = new Size(1000, 530);
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

		/// <summary>
		/// Toggle password view
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bbiTogglePassword_ItemClick(object sender, ItemClickEventArgs e)
		{
			NavigationPage newPage = navigationFrame.SelectedPage == npPasswords ? npCommands : npPasswords;

			navigationFrame.SelectedPage = newPage;

			if (newPage == npPasswords)
			{
				LoadPasswords(true);
				bbiTogglePassword.Caption = "Show Commands";
				bbiTogglePassword.ImageOptions.SvgImage = Resources.undo;
			}
			else
			{
				LoadCommands();
				bbiTogglePassword.Caption = "Show Passwords";
				bbiTogglePassword.ImageOptions.SvgImage = Resources.bo_user;
			}
		}

		#endregion

		#region TV COMMANDS

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

			bsiStatus.ItemAppearance.Normal.ForeColor = Color.Green;
			bsiStatus.Caption = $"Command '{e.RowHandle}' moved!";
		}

		#endregion

		#region FUNCTIONS

		/// <summary>
		/// Load Commands to list
		/// </summary>
		private void LoadCommands(bool showmsg = true)
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
					List<CommandsModel> commands = CommandsModel.Get(filters);
					commandsModelBindingSource.DataSource = commands;

					if (showmsg)
					{
						bsiStatus.ItemAppearance.Normal.Reset();
						bsiStatus.Caption = $"'{commands.Count}' commands found!";
					}
				}
			})
			.ContinueWith(t =>
			{
				tvCommands.EndDataUpdate();
			}, TaskScheduler.FromCurrentSynchronizationContext());

		}


		/// <summary>
		/// Load Passwords to list
		/// </summary>
		private void LoadPasswords(bool showmsg = true)
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
						bsiStatus.ItemAppearance.Normal.Reset();
						bsiStatus.Caption = $"'{passwords.Count}' passwords found!";
					}
				}
			})
			.ContinueWith(t =>
			{
				gvPasswords.EndDataUpdate();
				gvPasswords.HideLoadingPanel();
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

			try
			{
				if (!file.Enabled)
				{
					bsiStatus.ItemAppearance.Normal.ForeColor = Color.Red;
					bsiStatus.Caption = "Command is disabled!";
					return Task.CompletedTask;
				}
				batchFilePath = Path.Combine(Path.GetTempPath(), $"temp_{Guid.NewGuid()}");
				if (file.Type == Enums.CommandTypeEnum.CMD)
				{
					batchFilePath += ".bat";
					fileName = "cmd.exe";
					arguments = $"/C \"{batchFilePath}\"";
				}
				else if (file.Type == Enums.CommandTypeEnum.PS1)
				{
					batchFilePath += ".ps1";
					fileName = "powershell.exe";
					arguments = $"-ExecutionPolicy Bypass -File \"{batchFilePath}\"";
				}
				else if (file.Type == Enums.CommandTypeEnum.PY)
				{
					batchFilePath += ".py";
					fileName = "py";
					arguments = $" \"{batchFilePath}\"";
				}
				else
				{
					bsiStatus.ItemAppearance.Normal.ForeColor = Color.Red;
					bsiStatus.Caption = "Command not supported!";
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

		/// <summary>
		/// Loads the form size
		/// </summary>
		private void LoadSettings()
		{
			if (int.TryParse(ConfigurationManager.AppSettings["FormWidth"], out int width))
				this.Width = width;

			if (int.TryParse(ConfigurationManager.AppSettings["FormHeight"], out int height))
				this.Height = height;

			filters = new CommandFilterModel();

			if (bool.TryParse(ConfigurationManager.AppSettings[nameof(CommandFilterModel.ShowDisabled)], out bool showdisabled))
			{
				filters.ShowDisabled = showdisabled;
				btsiShowDisabled.Checked = showdisabled;
			}

			if (bool.TryParse(ConfigurationManager.AppSettings[nameof(CommandFilterModel.ShowCMD)], out bool showcmd))
			{
				filters.ShowCMD = showcmd;
				btsiFilterCmd.Checked = showcmd;
			}

			if (bool.TryParse(ConfigurationManager.AppSettings[nameof(CommandFilterModel.ShowPS1)], out bool showps1))
			{
				filters.ShowPS1 = showps1;
				btsiFilterPs1.Checked = showps1;
			}

			if (bool.TryParse(ConfigurationManager.AppSettings[nameof(CommandFilterModel.ShowPY)], out bool showpy))
			{
				filters.ShowPY = showpy;
				btsiFilterPy.Checked = showpy;
			}
		}

		#endregion

		#region CHECKED CHANGED

		private void btsiShowDisabled_CheckedChanged(object sender, ItemClickEventArgs e)
		{
			filters.ShowDisabled = btsiShowDisabled.Checked;
			LoadCommands();
		}

		private void btsiFilterCmd_CheckedChanged(object sender, ItemClickEventArgs e)
		{
			filters.ShowCMD = btsiFilterCmd.Checked;
			LoadCommands();
		}

		private void btsiFilterPs1_CheckedChanged(object sender, ItemClickEventArgs e)
		{
			filters.ShowPS1 = btsiFilterPs1.Checked;
			LoadCommands();
		}

		private void btsiFilterPy_CheckedChanged(object sender, ItemClickEventArgs e)
		{
			filters.ShowPY = btsiFilterPy.Checked;
			LoadCommands();
		}

		#endregion

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

				bsiStatus.ItemAppearance.Normal.ForeColor = Color.Green;
				bsiStatus.Caption = "Password saved!";
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
				var result = XtraMessageBox.Show($"Do you realy want to delete '{passwordsModel.Name}'?", "Delete password", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					PasswordsModel.DeleteFromXml(passwordsModel.Id);

					bsiStatus.ItemAppearance.Normal.ForeColor = Color.Red;
					bsiStatus.Caption = "Password deleted!";

					passwordsModelBindingSource.Remove(passwordsModel);
				}
			}
		}
	}
}
