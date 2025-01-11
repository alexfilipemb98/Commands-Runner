using Commands_Runner.Forms;
using Commands_Runner.Helpers;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using Microsoft.Win32;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Commands_Runner
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                if (IsDarkThemeEnabled())
                    UserLookAndFeel.Default.ActiveLookAndFeel.SetSkinStyle(SkinStyle.WXI, "DARK");

                SplashScreenManager.ShowForm(typeof(LoadingForm), true, true);

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                AppHelper.Configs = ConfigsModel.ReadFile(out bool primaveraExtensionsOK);

                if (primaveraExtensionsOK)
                    AppHelper.SqlStart();

                MainForm main = new MainForm();

                main.Shown += (object sender, EventArgs e) =>
                {
                    AppHelper.SqlStausLabel();
                    SplashScreenManager.CloseForm();
                };

                Application.Run(main);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), ex.TargetSite.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                AppHelper.SQL?.Dispose();
            }
        }

        public static bool IsDarkThemeEnabled()
        {
            var registryKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize");
            if (registryKey != null)
            {
                var value = registryKey.GetValue("AppsUseLightTheme");
                if (value != null && (int)value == 0)
                {
                    return true; // Modo escuro está ativado
                }
            }
            return false; // Modo claro está ativado
        }

    }
}
