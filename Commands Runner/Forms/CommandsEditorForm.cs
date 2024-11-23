using Commands_Runner.Enums;
using Commands_Runner.Extensions;
using Commands_Runner.Models;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Commands_Runner.Forms
{
    public partial class CommandsEditorForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private CommandsModel command;

        public CommandsEditorForm(CommandsModel command)
        {
            InitializeComponent();

            this.command = command;

            if (command.Id == 0)
                this.Text = "New Command";
            else
                this.Text = $"Edit Command Id '{command.Id}'";

            var listaEnum = typeof(CommandTypeEnum).ToList();
            cbeType.Properties.DataSource = listaEnum;
            cbeType.Properties.DropDownRows = Math.Min(listaEnum.Count, 7);

            meCommand.EditValue = command.Command;
            teDescription.EditValue = command.Description;
            teName.EditValue = command.Name;
            cbeType.EditValue = command.Type;
            tsEnabled.EditValue = command.Enabled;


        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string type = cbeType.EditValue?.ToString();
            string fileContent = meCommand.EditValue?.ToString();
            string fileName = teName.EditValue?.ToString();

            if (!ValidarCampos()) return;
         
            CommandTypeEnum commandType = EnumExtension.GetEnumByName<CommandTypeEnum>(type, true);
            if (CommandsModel.SaveCommandToFile(commandType, fileContent, fileName))
                XtraMessageBox.Show(
                        "File saved successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
        }

        private void sbSave_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            string type = cbeType.EditValue.ToString();

            command.Command = meCommand.EditValue?.ToString();
            command.Description = teDescription.EditValue?.ToString();
            command.Name = teName.EditValue?.ToString();
            command.Type = EnumExtension.GetEnumByName<CommandTypeEnum>(type, true);
            command.Enabled = (bool)tsEnabled.EditValue;

            CommandsModel.SaveToXml(command);

            this.DialogResult = DialogResult.OK;
        }

        private bool ValidarCampos()
        {
            dxErrorProvider.ClearErrors();

            if (string.IsNullOrWhiteSpace(teName.Text))
                dxErrorProvider.SetError(teName, "Name is required!");

            if (string.IsNullOrWhiteSpace(teDescription.Text))
                dxErrorProvider.SetError(teDescription, "Description is required!");

            if (string.IsNullOrWhiteSpace(cbeType.Text))
                dxErrorProvider.SetError(cbeType, "Type is required!");

            if (string.IsNullOrWhiteSpace(meCommand.Text))
                dxErrorProvider.SetError(meCommand, "Commnand is required!");

            return !dxErrorProvider.HasErrors;
        }

        public static DialogResult Show(CommandsModel command)
        {
            using (CommandsEditorForm frm = new CommandsEditorForm(command))
            {
                return frm.ShowDialog();
            }
        }
    }
}