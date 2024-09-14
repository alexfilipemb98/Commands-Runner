using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Commands_Runner
{
    internal static class Program
    {

        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int SW_SHOW = 5;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (IsDarkThemeEnabled())
                UserLookAndFeel.Default.ActiveLookAndFeel.SetSkinStyle(SkinStyle.WXI, "DARK");

            string processName = Process.GetCurrentProcess().ProcessName;
            bool createdNew;
            Mutex mutex = new Mutex(true, "UniqueAppNameMutex", out createdNew);

            if (!createdNew)
            {
                // Get the process ID of the running instance
                var existingProcess = GetExistingProcess();
                if (existingProcess != null)
                {
                    // Bring the existing window to the foreground
                    IntPtr hWnd = FindWindow(null, existingProcess.MainWindowTitle);
                    if (hWnd != IntPtr.Zero)
                    {
                        ShowWindow(hWnd, SW_SHOW);
                        SetForegroundWindow(hWnd);
                    }
                }
                return;
            }

            Application.Run(new Main());
        }

       private static Process GetExistingProcess()
        {
            var processName = Process.GetCurrentProcess().ProcessName;
            foreach (var process in Process.GetProcessesByName(processName))
            {
                // Ensure it's not the current process
                if (process.Id != Process.GetCurrentProcess().Id)
                {
                    return process;
                }
            }
            return null;
        }

        private static bool IsDarkThemeEnabled()
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
