using MobileManagement.Data.Db;
using System;
using System.Windows.Forms;
using MobileManagement.Logging;
using MobileManagement.Data.Repository;

namespace MobileManagement.UI
{
    public partial class MainForm : Form
    {
        private IRepository _repository;

        public MainForm(IRepository repository)
        {
            InitializeComponent();
            _repository = repository;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {   
            Logging.Logger.Instance.LogInfo("Application started");
        }


        

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Users usersForm = new Users(_repository);
            usersForm.MdiParent = this;
            usersForm.Show();
        }

        private void btnDevices_Click(object sender, EventArgs e)
        {
            Devices devicesForm = new Devices(_repository);
            devicesForm.MdiParent = this;
            devicesForm.Show();
        }

        private void btnManufacturers_Click(object sender, EventArgs e)
        {
            Manufacturers manufacturersForm = new Manufacturers(_repository);
            manufacturersForm.MdiParent = this;
            manufacturersForm.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report reportForm = new Report(_repository);
            reportForm.MdiParent = this;
            reportForm.Show();
        }
    }
}
