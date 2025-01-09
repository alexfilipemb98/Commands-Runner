using Commands_Runner.Forms;
using Commands_Runner.Helpers;
using Commands_Runner.Models;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using Microsoft.Win32;
using System;
using System.Data.SqlClient;
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

                ConnectionSQLModel connectionSQLModel = ConnectionSQLModel.ReadFile(out bool primaveraExtensionsOK);

                if (primaveraExtensionsOK)
                {
                    SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder
                    {
                        UserID = connectionSQLModel.UserID,
                        Password = connectionSQLModel.Password,
                        InitialCatalog = connectionSQLModel.InitialCatalog,
                        DataSource = connectionSQLModel.DataSource,
                        ConnectTimeout = 0,
                        PersistSecurityInfo = true,
                        IntegratedSecurity = false,
                        MultipleActiveResultSets = true,
                        AsynchronousProcessing = true
                    };

                    AppHelper.SQL = new SqlDataAccess(scsb.ToString());
                }

                MainForm main = new MainForm();

                main.Shown += (object sender, EventArgs e) =>
                {
                    main.npPrimaveraExtensions.PageEnabled = primaveraExtensionsOK;

                    SplashScreenManager.CloseForm();
                };

                Application.Run(main);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), ex.TargetSite.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
