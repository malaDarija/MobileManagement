namespace MobileManagement.UI
{
    partial class Devices
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
            this.idLbl = new System.Windows.Forms.Label();
            this.modelLbl = new System.Windows.Forms.Label();
            this.imeiLbl = new System.Windows.Forms.Label();
            this.userLbl = new System.Windows.Forms.Label();
            this.manufacturerLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.deviceAddBtn = new System.Windows.Forms.Button();
            this.deviceResetBtn = new System.Windows.Forms.Button();
            this.deviceDeleteBtn = new System.Windows.Forms.Button();
            this.deviceIdTb = new System.Windows.Forms.TextBox();
            this.imeiTb = new System.Windows.Forms.TextBox();
            this.modelTb = new System.Windows.Forms.TextBox();
            this.manufacturerCb = new System.Windows.Forms.ComboBox();
            this.userCb = new System.Windows.Forms.ComboBox();
            this.phoneNmbrTb = new System.Windows.Forms.TextBox();
            this.priceTb = new System.Windows.Forms.TextBox();
            this.tblDevices = new System.Windows.Forms.DataGridView();
            this.btnRefreshUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblDevices)).BeginInit();
            this.SuspendLayout();
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLbl.Location = new System.Drawing.Point(26, 29);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(22, 17);
            this.idLbl.TabIndex = 0;
            this.idLbl.Text = "Id:";
            // 
            // modelLbl
            // 
            this.modelLbl.AutoSize = true;
            this.modelLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLbl.Location = new System.Drawing.Point(26, 81);
            this.modelLbl.Name = "modelLbl";
            this.modelLbl.Size = new System.Drawing.Size(49, 17);
            this.modelLbl.TabIndex = 1;
            this.modelLbl.Text = "Model:";
            // 
            // imeiLbl
            // 
            this.imeiLbl.AutoSize = true;
            this.imeiLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imeiLbl.Location = new System.Drawing.Point(26, 55);
            this.imeiLbl.Name = "imeiLbl";
            this.imeiLbl.Size = new System.Drawing.Size(36, 17);
            this.imeiLbl.TabIndex = 2;
            this.imeiLbl.Text = "IMEI:";
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLbl.Location = new System.Drawing.Point(26, 134);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(38, 17);
            this.userLbl.TabIndex = 3;
            this.userLbl.Text = "User:";
            // 
            // manufacturerLbl
            // 
            this.manufacturerLbl.AutoSize = true;
            this.manufacturerLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturerLbl.Location = new System.Drawing.Point(26, 107);
            this.manufacturerLbl.Name = "manufacturerLbl";
            this.manufacturerLbl.Size = new System.Drawing.Size(89, 17);
            this.manufacturerLbl.TabIndex = 4;
            this.manufacturerLbl.Text = "Manufacturer:";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLbl.Location = new System.Drawing.Point(26, 161);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(96, 17);
            this.phoneLbl.TabIndex = 5;
            this.phoneLbl.Text = "Phone number:";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLbl.Location = new System.Drawing.Point(26, 187);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(39, 17);
            this.priceLbl.TabIndex = 6;
            this.priceLbl.Text = "Price:";
            // 
            // deviceAddBtn
            // 
            this.deviceAddBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviceAddBtn.Location = new System.Drawing.Point(39, 228);
            this.deviceAddBtn.Name = "deviceAddBtn";
            this.deviceAddBtn.Size = new System.Drawing.Size(75, 33);
            this.deviceAddBtn.TabIndex = 7;
            this.deviceAddBtn.Text = "Add";
            this.deviceAddBtn.UseVisualStyleBackColor = true;
            this.deviceAddBtn.Click += new System.EventHandler(this.deviceAddBtn_Click);
            // 
            // deviceResetBtn
            // 
            this.deviceResetBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviceResetBtn.Location = new System.Drawing.Point(132, 228);
            this.deviceResetBtn.Name = "deviceResetBtn";
            this.deviceResetBtn.Size = new System.Drawing.Size(75, 33);
            this.deviceResetBtn.TabIndex = 8;
            this.deviceResetBtn.Text = "Reset";
            this.deviceResetBtn.UseVisualStyleBackColor = true;
            this.deviceResetBtn.Click += new System.EventHandler(this.deviceResetBtn_Click);
            // 
            // deviceDeleteBtn
            // 
            this.deviceDeleteBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviceDeleteBtn.Location = new System.Drawing.Point(226, 228);
            this.deviceDeleteBtn.Name = "deviceDeleteBtn";
            this.deviceDeleteBtn.Size = new System.Drawing.Size(75, 33);
            this.deviceDeleteBtn.TabIndex = 9;
            this.deviceDeleteBtn.Text = "Delete";
            this.deviceDeleteBtn.UseVisualStyleBackColor = true;
            this.deviceDeleteBtn.Click += new System.EventHandler(this.deviceDeleteBtn_Click);
            // 
            // deviceIdTb
            // 
            this.deviceIdTb.Enabled = false;
            this.deviceIdTb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviceIdTb.Location = new System.Drawing.Point(132, 29);
            this.deviceIdTb.Name = "deviceIdTb";
            this.deviceIdTb.Size = new System.Drawing.Size(169, 25);
            this.deviceIdTb.TabIndex = 10;
            // 
            // imeiTb
            // 
            this.imeiTb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imeiTb.Location = new System.Drawing.Point(132, 55);
            this.imeiTb.Name = "imeiTb";
            this.imeiTb.Size = new System.Drawing.Size(169, 25);
            this.imeiTb.TabIndex = 11;
            // 
            // modelTb
            // 
            this.modelTb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelTb.Location = new System.Drawing.Point(132, 81);
            this.modelTb.Name = "modelTb";
            this.modelTb.Size = new System.Drawing.Size(169, 25);
            this.modelTb.TabIndex = 12;
            // 
            // manufacturerCb
            // 
            this.manufacturerCb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturerCb.FormattingEnabled = true;
            this.manufacturerCb.Location = new System.Drawing.Point(132, 107);
            this.manufacturerCb.Name = "manufacturerCb";
            this.manufacturerCb.Size = new System.Drawing.Size(169, 25);
            this.manufacturerCb.TabIndex = 13;
            // 
            // userCb
            // 
            this.userCb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userCb.FormattingEnabled = true;
            this.userCb.Location = new System.Drawing.Point(132, 134);
            this.userCb.Name = "userCb";
            this.userCb.Size = new System.Drawing.Size(169, 25);
            this.userCb.TabIndex = 14;
            // 
            // phoneNmbrTb
            // 
            this.phoneNmbrTb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNmbrTb.Location = new System.Drawing.Point(132, 161);
            this.phoneNmbrTb.Name = "phoneNmbrTb";
            this.phoneNmbrTb.Size = new System.Drawing.Size(169, 25);
            this.phoneNmbrTb.TabIndex = 15;
            // 
            // priceTb
            // 
            this.priceTb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTb.Location = new System.Drawing.Point(132, 187);
            this.priceTb.Name = "priceTb";
            this.priceTb.Size = new System.Drawing.Size(169, 25);
            this.priceTb.TabIndex = 16;
            // 
            // tblDevices
            // 
            this.tblDevices.AllowUserToAddRows = false;
            this.tblDevices.AllowUserToDeleteRows = false;
            this.tblDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDevices.Location = new System.Drawing.Point(330, 29);
            this.tblDevices.Name = "tblDevices";
            this.tblDevices.ReadOnly = true;
            this.tblDevices.Size = new System.Drawing.Size(916, 232);
            this.tblDevices.TabIndex = 17;
            this.tblDevices.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tblDevices_CellMouseDoubleClick);
            // 
            // btnRefreshUsers
            // 
            this.btnRefreshUsers.Location = new System.Drawing.Point(39, 281);
            this.btnRefreshUsers.Name = "btnRefreshUsers";
            this.btnRefreshUsers.Size = new System.Drawing.Size(262, 23);
            this.btnRefreshUsers.TabIndex = 18;
            this.btnRefreshUsers.Text = "Refresh users";
            this.btnRefreshUsers.UseVisualStyleBackColor = true;
            this.btnRefreshUsers.Click += new System.EventHandler(this.btnRefreshUsers_Click);
            // 
            // Devices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 325);
            this.Controls.Add(this.btnRefreshUsers);
            this.Controls.Add(this.tblDevices);
            this.Controls.Add(this.priceTb);
            this.Controls.Add(this.phoneNmbrTb);
            this.Controls.Add(this.userCb);
            this.Controls.Add(this.manufacturerCb);
            this.Controls.Add(this.modelTb);
            this.Controls.Add(this.imeiTb);
            this.Controls.Add(this.deviceIdTb);
            this.Controls.Add(this.deviceDeleteBtn);
            this.Controls.Add(this.deviceResetBtn);
            this.Controls.Add(this.deviceAddBtn);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.manufacturerLbl);
            this.Controls.Add(this.userLbl);
            this.Controls.Add(this.imeiLbl);
            this.Controls.Add(this.modelLbl);
            this.Controls.Add(this.idLbl);
            this.Name = "Devices";
            this.Text = "Devices";
            this.Load += new System.EventHandler(this.Devices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblDevices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label modelLbl;
        private System.Windows.Forms.Label imeiLbl;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.Label manufacturerLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Button deviceAddBtn;
        private System.Windows.Forms.Button deviceResetBtn;
        private System.Windows.Forms.Button deviceDeleteBtn;
        private System.Windows.Forms.TextBox deviceIdTb;
        private System.Windows.Forms.TextBox imeiTb;
        private System.Windows.Forms.TextBox modelTb;
        private System.Windows.Forms.ComboBox manufacturerCb;
        private System.Windows.Forms.ComboBox userCb;
        private System.Windows.Forms.TextBox phoneNmbrTb;
        private System.Windows.Forms.TextBox priceTb;
        private System.Windows.Forms.DataGridView tblDevices;
        private System.Windows.Forms.Button btnRefreshUsers;
    }
}