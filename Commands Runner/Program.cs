using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
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

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("kernel32.dll")]
        private static extern uint GetCurrentThreadId();

        [DllImport("user32.dll")]
        private static extern bool AllowSetForegroundWindow(int dwProcessId);

        [DllImport("user32.dll")]
        private static extern bool AttachThreadInput(uint idAttach, uint idAttachTo, bool fAttach);

        [DllImport("user32.dll")]
        private static extern uint GetWindowThreadProcessId(IntPtr hWnd, IntPtr ProcessId);

        private static volatile Mutex mutex;

        private const int SW_SHOW = 5;
        private const int SW_RESTORE = 9;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (IsDarkThemeEnabled())
                UserLookAndFeel.Default.ActiveLookAndFeel.SetSkinStyle(SkinStyle.WXI, "DARK");

            string processName = Process.GetCurrentProcess().ProcessName;
            bool createdNew;
            mutex = new Mutex(true, "CommandsRunnerMutex", out createdNew);

            if (!createdNew)
            {
                Thread.Sleep(100);

                Process existingProcess = GetExistingProcess();

                if (existingProcess != null)
                {
                    AllowSetForegroundWindow(existingProcess.Id);
                    IntPtr hWnd = FindWindow(null, existingProcess.MainWindowTitle);

                    if (hWnd != IntPtr.Zero)
                    {
                        uint foregroundThread = GetWindowThreadProcessId(GetForegroundWindow(), IntPtr.Zero);
                        uint currentThread = GetCurrentThreadId();

                        if (AttachThreadInput(currentThread, foregroundThread, true))
                        {
                            ShowWindow(hWnd, SW_SHOW);
                            SetForegroundWindow(hWnd);
                            AttachThreadInput(currentThread, foregroundThread, false);
                        }
                    }
                }

                return;
            }

            Application.Run(new Main());
        }

        public static void BringToFront(string windowTitle)
        {
            IntPtr hWnd = FindWindow(null, windowTitle);
            if (hWnd != IntPtr.Zero)
            {
                ShowWindow(hWnd, SW_RESTORE);
                SetForegroundWindow(hWnd);
            }
        }

        private static Process GetExistingProcess()
        {
            string processName = Process.GetCurrentProcess().ProcessName;
            foreach (Process process in Process.GetProcessesByName(processName))
            {
                if (process.Id != Process.GetCurrentProcess().Id)
                    return process;
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
