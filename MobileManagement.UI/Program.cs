using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MobileManagement.Data.Db;
using MobileManagement.Data.Repository;

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
