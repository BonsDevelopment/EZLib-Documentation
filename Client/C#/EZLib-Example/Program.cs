using System;
using System.Windows.Forms;

namespace EZLib.Test
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Tools to help stop anti-reversing.
            var settings = new EzLibSettings
            {
                AntiDebug = false,
                AntiDump = false,
                AntiVm = false,
                AntiSandboxie = false
            };

            var init = new Initialize("APP_TOKEN", "APP_VERSION", settings);

            // Have your application be licensed by EZLib and offer a free mode time for your startup.
            if (init.IsFreeMode())
                Application.Run(new MainForm());
            else
                Application.Run(new LoginForm());
        }
    }
}
