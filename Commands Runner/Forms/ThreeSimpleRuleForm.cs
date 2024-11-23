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

namespace Commands_Runner.Forms
{
	public partial class ThreeSimpleRuleForm : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		public ThreeSimpleRuleForm()
		{
			InitializeComponent();
		}

		private void teA2Value_EditValueChanged(object sender, EventArgs e)
		{
			if (teAValue.EditValue != null && teBValue.EditValue != null && teA2Value.EditValue != null)
				teResult.Text = (((decimal)teAValue.EditValue * (decimal)teBValue.EditValue) / (decimal)teA2Value.EditValue).ToString();
		}
	}
}