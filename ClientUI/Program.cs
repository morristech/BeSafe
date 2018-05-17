using System;
using System.Threading;
using System.Windows.Forms;

namespace ClientUI
{
    static class Program
    {
        private static Mutex singleInstanceAppMutex = new Mutex(true, "5a5fbcc6-a300-4089-9e3b-26c913425d76");

        [STAThread]
        static void Main()
        {
            if (!singleInstanceAppMutex.WaitOne(TimeSpan.Zero, true))
                return;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Setting());
        }
    }
}