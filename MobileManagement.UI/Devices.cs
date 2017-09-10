using MobileManagement.Data.Helper;
using MobileManagement.Data.Model;
using MobileManagement.Data.Repository;
using MobileManagement.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MobileManagement.UI
{
    public partial class Devices : Form
    {

        private IRepository _repository;

        public Devices(IRepository repository)
        {
            InitializeComponent();
            _repository = repository;
        }

        private void Devices_Load(object sender, EventArgs e)
        {
            #region Manufacturer DDL
            manufacturerCb.DataSource = _repository.GetAllManufacturers();
            manufacturerCb.ValueMember = "Id";
            manufacturerCb.DisplayMember = "Name";
            #endregion

            RefreshDevicesTable();
            FillUserDdl();
        }

        private void RefreshDevicesTable()
        {
            tblDevices.DataSource = _repository.GetAllDevices();
            tblDevices.Columns[tblDevices.Columns.Count - 1].Visible = false;
            tblDevices.Columns[tblDevices.Columns.Count - 2].Visible = false;
        }

        private void deviceAddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(imeiTb.Text) || string.IsNullOrEmpty(modelTb.Text) || string.IsNullOrEmpty(priceTb.Text) || !priceTb.Text.IsValidPrice())
            {
                MessageBox.Show("Test");
                return;
            }

            //Validacija vezana za price i usera 
            var price = decimal.Parse(priceTb.Text);

            Device device = new Device()
            {
                Imei = imeiTb.Text,
                PhoneNumber = phoneNmbrTb.Text,
                Price = price,
                Model = modelTb.Text,
                ManufacturerId = (int)manufacturerCb.SelectedValue,
            };

            var selectedUserId = (int)userCb.SelectedValue;
            if (selectedUserId != -1)
            {
                //DOhvati korisnika po idu
                var selectedUserType = _repository.GetUserTypeForUserId(selectedUserId);

                var minimumUserType = price.GetMinimumUserType();
                if ((int)selectedUserType < (int)minimumUserType)
                {
                    MessageBox.Show("Odabrani korisnik nema zadovoljavajuću poziciju.");
                    return;
                }

                device.UserId = selectedUserId;
            }

            if (string.IsNullOrEmpty(deviceIdTb.Text))
            {
                //Add
                _repository.AddDevice(device);
            }
            else
            {
                //Edit
                device.Id = int.Parse(deviceIdTb.Text);
                _repository.EditDevice(device);
            }

            RefreshDevicesTable();
            ResetForm();
        }

        private void ResetForm()
        {
            deviceIdTb.Text = "";
            imeiTb.Text = "";
            modelTb.Text = "";
            phoneNmbrTb.Text = "";
            priceTb.Text = "";
            FillUserDdl();
            manufacturerCb.SelectedIndex = 0;
        }

        private void deviceResetBtn_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void deviceDeleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(deviceIdTb.Text))
            {
                MessageBox.Show("Greška! Ništa nije odabrano!");
                return;
            }

            DialogResult result = MessageBox.Show($"Jeste li sigurni da želite izbrisati {modelTb.Text}?", "Jeste li sigurni?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var deviceId = int.Parse(deviceIdTb.Text);
                _repository.DeleteDevice(deviceId);
                ResetForm();
                RefreshDevicesTable();
            }
        }

        private void FillUserDdl(decimal? price = null)
        {
            List<UserVM> users;
            if (price.HasValue)
            {
                users = _repository.GetAllPotentialUsersForDevicePrice(price.Value);
            }
            else
            {
                users = _repository.GetAllUsers();
            }


            users.Insert(0, new UserVM()
            {
                Id = -1,
                FirstName = "-"
            });
            userCb.DataSource = users;
            userCb.ValueMember = "Id";
            userCb.DisplayMember = "DisplayName";
        }

        private void tblDevices_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (tblDevices.SelectedRows.Count == 0)
            {
                return;
            }

            var selectedDeviceId = (int)tblDevices.SelectedRows[0].Cells[0].Value;

            var selectedDevice = _repository.GetDeviceVMById(selectedDeviceId);

            deviceIdTb.Text = selectedDevice.Id.ToString();
            imeiTb.Text = selectedDevice.Imei;
            phoneNmbrTb.Text = selectedDevice.PhoneNumber;
            priceTb.Text = selectedDevice.Price.ToString();
            modelTb.Text = selectedDevice.Model;
            manufacturerCb.SelectedValue = selectedDevice.ManufacturerId;
            
            FillUserDdl(selectedDevice.Price);

            if (selectedDevice.UserId.HasValue)
            {
                userCb.SelectedValue = selectedDevice.UserId.Value;
            }
            else
            {
                userCb.SelectedIndex = 0;
            }
        }

        private void btnRefreshUsers_Click(object sender, EventArgs e)
        {
            decimal? price = null;
            if (!string.IsNullOrEmpty(priceTb.Text))
            {
                price = decimal.Parse(priceTb.Text);
            }
            FillUserDdl(price);
        }


    }
}
