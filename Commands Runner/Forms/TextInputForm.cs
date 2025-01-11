using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commands_Runner.Forms
{
    public partial class TextInputForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public TextInputForm() => InitializeComponent();

        public static DialogResult SD(ref string text)
        {
            using (TextInputForm form = new TextInputForm())
            {
                form.teText.Text = text;
                DialogResult result = form.ShowDialog();
                text = form.teText.Text;
                return result;
            }
        }

        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendData();
        }

        private void SendData()
        {
            dxErrorProvider.ClearErrors();

            if (string.IsNullOrWhiteSpace(teText.Text))
            {
                dxErrorProvider.SetError(teText, "Text is required!");
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void simpleButton1_Click(object sender, EventArgs e) => SendData();
    }
}