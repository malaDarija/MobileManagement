namespace MobileManagement.UI
{
    partial class Users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstNameTb = new System.Windows.Forms.TextBox();
            this.lastNameTb = new System.Windows.Forms.TextBox();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.userTypeLbl = new System.Windows.Forms.Label();
            this.userTypeCb = new System.Windows.Forms.ComboBox();
            this.tblUsers = new System.Windows.Forms.DataGridView();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.izbrisiBtn = new System.Windows.Forms.Button();
            this.IdTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRestartForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameTb
            // 
            this.firstNameTb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTb.Location = new System.Drawing.Point(133, 72);
            this.firstNameTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstNameTb.Name = "firstNameTb";
            this.firstNameTb.Size = new System.Drawing.Size(200, 25);
            this.firstNameTb.TabIndex = 0;
            // 
            // lastNameTb
            // 
            this.lastNameTb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTb.Location = new System.Drawing.Point(133, 105);
            this.lastNameTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastNameTb.Name = "lastNameTb";
            this.lastNameTb.Size = new System.Drawing.Size(200, 25);
            this.lastNameTb.TabIndex = 1;
            // 
            // emailTb
            // 
            this.emailTb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTb.Location = new System.Drawing.Point(133, 138);
            this.emailTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(200, 25);
            this.emailTb.TabIndex = 2;
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLbl.Location = new System.Drawing.Point(25, 76);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(71, 17);
            this.firstNameLbl.TabIndex = 4;
            this.firstNameLbl.Text = "First name:";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLbl.Location = new System.Drawing.Point(25, 109);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(70, 17);
            this.lastNameLbl.TabIndex = 5;
            this.lastNameLbl.Text = "Last name:";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.Location = new System.Drawing.Point(25, 141);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(42, 17);
            this.emailLbl.TabIndex = 6;
            this.emailLbl.Text = "Email:";
            // 
            // userTypeLbl
            // 
            this.userTypeLbl.AutoSize = true;
            this.userTypeLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTypeLbl.Location = new System.Drawing.Point(25, 175);
            this.userTypeLbl.Name = "userTypeLbl";
            this.userTypeLbl.Size = new System.Drawing.Size(67, 17);
            this.userTypeLbl.TabIndex = 8;
            this.userTypeLbl.Text = "User type:";
            // 
            // userTypeCb
            // 
            this.userTypeCb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTypeCb.FormattingEnabled = true;
            this.userTypeCb.Location = new System.Drawing.Point(133, 171);
            this.userTypeCb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userTypeCb.Name = "userTypeCb";
            this.userTypeCb.Size = new System.Drawing.Size(200, 25);
            this.userTypeCb.TabIndex = 9;
            // 
            // tblUsers
            // 
            this.tblUsers.AllowUserToAddRows = false;
            this.tblUsers.AllowUserToDeleteRows = false;
            this.tblUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblUsers.Location = new System.Drawing.Point(370, 30);
            this.tblUsers.Name = "tblUsers";
            this.tblUsers.ReadOnly = true;
            this.tblUsers.Size = new System.Drawing.Size(637, 301);
            this.tblUsers.TabIndex = 10;
            this.tblUsers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tblUsers_MouseDoubleClick);
            // 
            // dodajBtn
            // 
            this.dodajBtn.Location = new System.Drawing.Point(115, 214);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(63, 33);
            this.dodajBtn.TabIndex = 11;
            this.dodajBtn.Text = "Dodaj";
            this.dodajBtn.UseVisualStyleBackColor = true;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // izbrisiBtn
            // 
            this.izbrisiBtn.Location = new System.Drawing.Point(271, 214);
            this.izbrisiBtn.Name = "izbrisiBtn";
            this.izbrisiBtn.Size = new System.Drawing.Size(62, 33);
            this.izbrisiBtn.TabIndex = 12;
            this.izbrisiBtn.Text = "Izbriši";
            this.izbrisiBtn.UseVisualStyleBackColor = true;
            this.izbrisiBtn.Click += new System.EventHandler(this.izbrisiBtn_Click);
            // 
            // IdTb
            // 
            this.IdTb.Enabled = false;
            this.IdTb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTb.Location = new System.Drawing.Point(133, 39);
            this.IdTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IdTb.Name = "IdTb";
            this.IdTb.Size = new System.Drawing.Size(200, 25);
            this.IdTb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id: ";
            // 
            // btnRestartForm
            // 
            this.btnRestartForm.Location = new System.Drawing.Point(184, 214);
            this.btnRestartForm.Name = "btnRestartForm";
            this.btnRestartForm.Size = new System.Drawing.Size(81, 33);
            this.btnRestartForm.TabIndex = 13;
            this.btnRestartForm.Text = "Resetiraj";
            this.btnRestartForm.UseVisualStyleBackColor = true;
            this.btnRestartForm.Click += new System.EventHandler(this.btnRestartForm_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 400);
            this.Controls.Add(this.btnRestartForm);
            this.Controls.Add(this.izbrisiBtn);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.tblUsers);
            this.Controls.Add(this.userTypeCb);
            this.Controls.Add(this.userTypeLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.emailTb);
            this.Controls.Add(this.lastNameTb);
            this.Controls.Add(this.IdTb);
            this.Controls.Add(this.firstNameTb);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTb;
        private System.Windows.Forms.TextBox lastNameTb;
        private System.Windows.Forms.TextBox emailTb;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label userTypeLbl;
        private System.Windows.Forms.ComboBox userTypeCb;
        private System.Windows.Forms.DataGridView tblUsers;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.Button izbrisiBtn;
        private System.Windows.Forms.TextBox IdTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRestartForm;
    }
}