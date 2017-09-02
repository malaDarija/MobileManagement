using MobileManagement.Data.Db;
using MobileManagement.Data.Model;
using MobileManagement.Data.Repository;
using System;
using System.Windows.Forms;

namespace MobileManagement.UI
{
    public partial class Users : Form
    {
        private MobileManagementContext _db;
        private EfRepository _repository;
        
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            _db = new MobileManagementContext();
            _repository = new EfRepository(_db);

            RefreshUsersTable();

            #region User type combo box            
            userTypeCb.DataSource = _repository.GetAllUserTypes();
            userTypeCb.ValueMember = "Id";
            userTypeCb.DisplayMember = "Name";
            #endregion
        }

        private void RefreshUsersTable()
        {
            tblUsers.DataSource = _repository.GetAllUsers();
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
           if(string.IsNullOrEmpty(firstNameTb.Text) || string.IsNullOrEmpty(lastNameTb.Text) || string.IsNullOrEmpty(emailTb.Text))
            {
                MessageBox.Show("Greška, nedostaju podatci", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            User user = new User()
            {
                FirstName = firstNameTb.Text,
                LastName = lastNameTb.Text,                
                Email = emailTb.Text                
            };

            if(userTypeCb.SelectedValue != null)
            {
                user.UserType = (UserType)userTypeCb.SelectedValue;
            }

            if (string.IsNullOrEmpty(IdTb.Text))
            {
                _repository.AddUser(user);
            }
            else
            {
                user.Id = int.Parse(IdTb.Text);
                _repository.EditUser(user);
            }

            
            RestartForm();
            RefreshUsersTable();
        }

        private void RestartForm()
        {            
            IdTb.Text = "";
            firstNameTb.Text = "";
            lastNameTb.Text = "";            
            emailTb.Text = "";
        }

        private void izbrisiBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdTb.Text))
            {
                MessageBox.Show("Test");
                return;
            }

            DialogResult result = MessageBox.Show($"Jeste li sigurni da želite izbrisati {firstNameTb.Text} {lastNameTb.Text}?", "Jeste li sigurni?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                var userId = int.Parse(IdTb.Text);
                _repository.DeleteUser(userId);
                RestartForm();
                RefreshUsersTable();
            }
        }
        

        private void tblUsers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(tblUsers.SelectedRows.Count == 0)
            {
                return;
            }

            var selectedUserId = (int)tblUsers.SelectedRows[0].Cells[0].Value;
            var selectedUser = _repository.GetUserVMById(selectedUserId);

            IdTb.Text = selectedUser.Id.ToString();
            firstNameTb.Text = selectedUser.FirstName;
            lastNameTb.Text = selectedUser.LastName;            
            emailTb.Text = selectedUser.Email;
            userTypeCb.SelectedValue = (int)Enum.Parse(typeof(UserType), selectedUser.UserType);
        }

        private void btnRestartForm_Click(object sender, EventArgs e)
        {
            RestartForm();
        }
    }
}
