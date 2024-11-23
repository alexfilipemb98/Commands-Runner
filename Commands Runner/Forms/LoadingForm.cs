using DevExpress.LookAndFeel;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Commands_Runner.Forms
{
    public partial class LoadingForm : SplashScreen
    {
        public LoadingForm()
        {
            InitializeComponent();

            if (Program.IsDarkThemeEnabled())
                peImage.BackColor = Color.FromArgb(36, 36, 36);
            else 
                peImage.BackColor = Color.FromArgb(244, 244, 244);
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
    }
}