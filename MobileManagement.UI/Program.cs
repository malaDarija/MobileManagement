using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MobileManagement.Data.Db;
using MobileManagement.Data.Repository;
using Metrics;

namespace MobileManagement.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Metric.Config.WithHttpEndpoint("http://localhost:1234/").WithAllCounters();
                       

            AllocConsole();
            using(MobileManagementContext db = new MobileManagementContext())
            {
                IRepository repository = new EfRepository(db);
                Application.Run(new MainForm(repository));
            }            
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
    }
}
