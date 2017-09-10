using MobileManagement.Data.Model;
using MobileManagement.Data.Repository;
using System;
using System.Windows.Forms;

namespace MobileManagement.UI
{
    public partial class Manufacturers : Form
    {
        private IRepository _repository;

        public Manufacturers(IRepository repository)
        {
            InitializeComponent();
            _repository = repository;
        }

        private void Manufacturers_Load(object sender, EventArgs e)
        {
            RefreshManufacturersTable();
        }

        private void RefreshManufacturersTable()
        {
            tblManufacturers.DataSource = _repository.GetAllManufacturers();
        }

        private void manufacturerAddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(manufacturerNameTb.Text))
            {
                MessageBox.Show("Nisu popunjena sva potrebna polja!");
                return;
            }

            Manufacturer manufacturer = new Manufacturer()
            {
                Name = manufacturerNameTb.Text
            };

            if (string.IsNullOrEmpty(manufacturerIdTb.Text))
            {
                //Add
                _repository.AddManufacturer(manufacturer);
            }
            else
            {
                //Edit
                manufacturer.Id = int.Parse(manufacturerIdTb.Text);
                _repository.EditManufacturer(manufacturer);
            }

            RefreshManufacturersTable();
            ResetForm();
        }

        private void ResetForm()
        {
            manufacturerIdTb.Text = "";
            manufacturerNameTb.Text = "";
        }

        private void manufacturerResetBtn_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void manufacturerDeleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(manufacturerIdTb.Text))
            {
                MessageBox.Show("Greška! Ništa nije odabrano!");
                return;
            }

            DialogResult result = MessageBox.Show($"Jeste li sigurni da želite izbrisati {manufacturerNameTb.Text}?", "Jeste li sigurni?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var manufacturerId = int.Parse(manufacturerIdTb.Text);
                _repository.DeleteManufacturer(manufacturerId);
                ResetForm();
                RefreshManufacturersTable();
            }
        }

        private void tblManufacturers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (tblManufacturers.SelectedRows.Count == 0)
            {
                return;
            }

            var selectedManufacturerId = (int)tblManufacturers.SelectedRows[0].Cells[0].Value;

            var selectedManufacturer = _repository.GetManufacturerById(selectedManufacturerId);

            manufacturerIdTb.Text = selectedManufacturer.Id.ToString();
            manufacturerNameTb.Text = selectedManufacturer.Name;
        }
    }
}
