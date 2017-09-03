using MobileManagement.Data.Db;
using MobileManagement.Data.Repository;
using MobileManagement.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileManagement.UI
{
    public partial class Report : Form
    {
        private MobileManagementContext _db;
        private IRepository _repository;

        public Report(MobileManagementContext db)
        {
            InitializeComponent();
            _db = db;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            _repository = new EfRepository(_db);

            #region Users DDL
            usersCb.ValueMember = "Id";
            usersCb.DisplayMember = "DisplayName";
            usersCb.DataSource = _repository.GetAllUsers();            
            #endregion

        }

        private void usersCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedValue = (int)usersCb.SelectedValue;

            tblDevices.DataSource = _repository.GetAllDevicesForUser((int)selectedValue);
            tblDevices.Columns[tblDevices.Columns.Count - 1].Visible = false;
            tblDevices.Columns[tblDevices.Columns.Count - 2].Visible = false;
            tblDevices.Columns[tblDevices.Columns.Count - 3].Visible = false;
        }
    }
}
