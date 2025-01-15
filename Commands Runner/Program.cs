using Commands_Runner.Data;
using Commands_Runner.Forms;
using Commands_Runner.Helpers;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Model;
using DevExpress.XtraSplashScreen;
using Life_Log.Components;
using Microsoft.Win32;
using System;
using System.Configuration;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Commands_Runner
{
    internal static class Program
    {
        [DllImport("User32.dll")]
        private static extern int SetForegroundWindow(IntPtr hWnd);

        [STAThread]
        static void Main()
        {
            try
            {
#if !DEBUG
                Process currentProcess = Process.GetCurrentProcess();
                Process checkProcess = Process.GetProcessesByName(currentProcess.ProcessName).FirstOrDefault(p => p.Id != currentProcess.Id);

                if (checkProcess != null)
                {
                    IntPtr hWnd = IntPtr.Zero;
                    hWnd = checkProcess.MainWindowHandle;
                    SetForegroundWindow(hWnd);
                    return;
                }
#endif

                if (IsDarkThemeEnabled())
                    UserLookAndFeel.Default.ActiveLookAndFeel.SetSkinStyle(SkinStyle.WXI, "DARK");

                SplashScreenManager.ShowForm(typeof(LoadingForm), true, true);

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                string connectionString = ConfigurationManager.ConnectionStrings["SQLiteConnection"].ConnectionString;

                AppHelper.DATA = new SqlDataAccess(connectionString, true);

                CommandsData.CheckTable();
                PasswordsData.CheckTable();
                NotesData.CheckTable();
                SettingsData.CheckTable();

                AppHelper.Configs = SettingsData.GetByID(Properties.Settings.Default.SettingId, out bool primaveraExtensionsOK);

                if (primaveraExtensionsOK)
                    AppHelper.SqlStart();

                MainForm main = new MainForm();

                AppHelper.Instance = main;

                main.WindowState = AppHelper.Configs.FormState;

                if (AppHelper.Configs.FormState != FormWindowState.Maximized)
                {
                    main.Width = AppHelper.Configs.FormWidth;
                    main.Height = AppHelper.Configs.FormHeight;
                }

                main.Shown += (object sender, EventArgs e) =>
                {
                    AppHelper.SqlStausLabel();

                    NavigationPageEx page = main.navigationPaneEx.Pages.FirstOrDefault(w => w.Caption == AppHelper.Configs.StartUpPage) as NavigationPageEx;
                    
                    if (page != null)
                        main.navigationPaneEx.SelectedPage = page;

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
                AppHelper.DATA?.Dispose();
            }
        }

        public static bool IsDarkThemeEnabled()
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize");

            if (registryKey != null)
            {
                object value = registryKey.GetValue("AppsUseLightTheme");
                if (value != null && (int)value == 0)
                    return true; // Modo escuro está ativado
            }

            return false; // Modo claro está ativado
        }
    }
}
