using DevExpress.Data.ExpressionEditor;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commands_Runner
{
    public partial class Editor : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private CommandsModel command;

        public Editor(CommandsModel command)
        {
            InitializeComponent();

            this.command = command;

            if (command.Id == 0)
                this.Text = "New Command";
            else
                this.Text = $"Edit Command Id '{command.Id}'";

            meCommand.EditValue = command.Command;
            teDescription.EditValue = command.Description;
            teName.EditValue = command.Name;
            cbeType.EditValue = command.Type;
            tsEnabled.EditValue = command.Enabled;
        }

        public static DialogResult Show(CommandsModel command)
        {
            using (Editor frm = new Editor(command))
            {
                return frm.ShowDialog();
            }
        }

        private void sbSave_Click(object sender, EventArgs e)
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


            if (dxErrorProvider.HasErrors) return;

            command.Command = meCommand.EditValue?.ToString();
            command.Description = teDescription.EditValue?.ToString();
            command.Name = teName.EditValue?.ToString();
            command.Type = cbeType.EditValue?.ToString();
            command.Enabled = (bool)tsEnabled.EditValue;

            CommandsModel.SaveToXml(command);

            this.DialogResult = DialogResult.OK;
        }
    }
}