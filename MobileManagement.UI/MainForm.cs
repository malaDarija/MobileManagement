using MobileManagement.Data.Db;
using System;
using System.Windows.Forms;
using MobileManagement.Logging;

namespace MobileManagement.UI
{
    public partial class MainForm : Form
    {        
        private MobileManagementContext _db;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _db = new MobileManagementContext();

            Logging.Logger.Instance.LogInfo("Application started");
        }


        

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Users usersForm = new Users(_db);
            usersForm.MdiParent = this;
            usersForm.Show();
        }

        private void btnDevices_Click(object sender, EventArgs e)
        {
            Devices devicesForm = new Devices(_db);
            devicesForm.MdiParent = this;
            devicesForm.Show();
        }

        private void btnManufacturers_Click(object sender, EventArgs e)
        {
            //TODO implement
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _db.Dispose();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report reportForm = new Report(_db);
            reportForm.MdiParent = this;
            reportForm.Show();
        }
    }
}
