using EZLib;
using System;
using System.Windows.Forms;

namespace EZLib_Example
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppDomain.CurrentDomain.UnhandledException +=
                (sender, args) => HandleUnhandledException(args.ExceptionObject as Exception);
            Application.ThreadException +=
                (sender, args) => HandleUnhandledException(args.Exception);

            var settings = new EzLibSettings
            {
                AntiDebug = false,
                AntiSuspend = true,
                AntiDump = true,
                AntiVM = true,
                AntiSandboxie = true,
                MainForm = new MainForm()
            };

            new Initialize("TOKEN", "VERSION", settings);
        }

        private static void HandleUnhandledException(Exception exception)
        {
            new Exceptions(exception);
        }
    }
}
