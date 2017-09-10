namespace MobileManagement.UI
{
    partial class Manufacturers
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
            this.manufacturerAddBtn = new System.Windows.Forms.Button();
            this.manufacturerResetBtn = new System.Windows.Forms.Button();
            this.manufacturerDeleteBtn = new System.Windows.Forms.Button();
            this.manufacturerIdLbl = new System.Windows.Forms.Label();
            this.manufacturerNameLbl = new System.Windows.Forms.Label();
            this.manufacturerIdTb = new System.Windows.Forms.TextBox();
            this.manufacturerNameTb = new System.Windows.Forms.TextBox();
            this.tblManufacturers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tblManufacturers)).BeginInit();
            this.SuspendLayout();
            // 
            // manufacturerAddBtn
            // 
            this.manufacturerAddBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturerAddBtn.Location = new System.Drawing.Point(46, 126);
            this.manufacturerAddBtn.Name = "manufacturerAddBtn";
            this.manufacturerAddBtn.Size = new System.Drawing.Size(75, 36);
            this.manufacturerAddBtn.TabIndex = 0;
            this.manufacturerAddBtn.Text = "Add";
            this.manufacturerAddBtn.UseVisualStyleBackColor = true;
            this.manufacturerAddBtn.Click += new System.EventHandler(this.manufacturerAddBtn_Click);
            // 
            // manufacturerResetBtn
            // 
            this.manufacturerResetBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturerResetBtn.Location = new System.Drawing.Point(127, 126);
            this.manufacturerResetBtn.Name = "manufacturerResetBtn";
            this.manufacturerResetBtn.Size = new System.Drawing.Size(75, 36);
            this.manufacturerResetBtn.TabIndex = 1;
            this.manufacturerResetBtn.Text = "Reset";
            this.manufacturerResetBtn.UseVisualStyleBackColor = true;
            this.manufacturerResetBtn.Click += new System.EventHandler(this.manufacturerResetBtn_Click);
            // 
            // manufacturerDeleteBtn
            // 
            this.manufacturerDeleteBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturerDeleteBtn.Location = new System.Drawing.Point(208, 126);
            this.manufacturerDeleteBtn.Name = "manufacturerDeleteBtn";
            this.manufacturerDeleteBtn.Size = new System.Drawing.Size(75, 36);
            this.manufacturerDeleteBtn.TabIndex = 2;
            this.manufacturerDeleteBtn.Text = "Delete";
            this.manufacturerDeleteBtn.UseVisualStyleBackColor = true;
            this.manufacturerDeleteBtn.Click += new System.EventHandler(this.manufacturerDeleteBtn_Click);
            // 
            // manufacturerIdLbl
            // 
            this.manufacturerIdLbl.AutoSize = true;
            this.manufacturerIdLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturerIdLbl.Location = new System.Drawing.Point(57, 30);
            this.manufacturerIdLbl.Name = "manufacturerIdLbl";
            this.manufacturerIdLbl.Size = new System.Drawing.Size(22, 17);
            this.manufacturerIdLbl.TabIndex = 3;
            this.manufacturerIdLbl.Text = "Id:";
            // 
            // manufacturerNameLbl
            // 
            this.manufacturerNameLbl.AutoSize = true;
            this.manufacturerNameLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturerNameLbl.Location = new System.Drawing.Point(33, 71);
            this.manufacturerNameLbl.Name = "manufacturerNameLbl";
            this.manufacturerNameLbl.Size = new System.Drawing.Size(46, 17);
            this.manufacturerNameLbl.TabIndex = 4;
            this.manufacturerNameLbl.Text = "Name:";
            // 
            // manufacturerIdTb
            // 
            this.manufacturerIdTb.Enabled = false;
            this.manufacturerIdTb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturerIdTb.Location = new System.Drawing.Point(105, 27);
            this.manufacturerIdTb.Name = "manufacturerIdTb";
            this.manufacturerIdTb.Size = new System.Drawing.Size(178, 25);
            this.manufacturerIdTb.TabIndex = 5;
            // 
            // manufacturerNameTb
            // 
            this.manufacturerNameTb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturerNameTb.Location = new System.Drawing.Point(105, 68);
            this.manufacturerNameTb.Name = "manufacturerNameTb";
            this.manufacturerNameTb.Size = new System.Drawing.Size(178, 25);
            this.manufacturerNameTb.TabIndex = 6;
            // 
            // tblManufacturers
            // 
            this.tblManufacturers.AllowUserToAddRows = false;
            this.tblManufacturers.AllowUserToDeleteRows = false;
            this.tblManufacturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblManufacturers.Location = new System.Drawing.Point(304, 27);
            this.tblManufacturers.Name = "tblManufacturers";
            this.tblManufacturers.ReadOnly = true;
            this.tblManufacturers.Size = new System.Drawing.Size(344, 135);
            this.tblManufacturers.TabIndex = 7;
            this.tblManufacturers.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tblManufacturers_CellMouseDoubleClick);
            // 
            // Manufacturers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 195);
            this.Controls.Add(this.tblManufacturers);
            this.Controls.Add(this.manufacturerNameTb);
            this.Controls.Add(this.manufacturerIdTb);
            this.Controls.Add(this.manufacturerNameLbl);
            this.Controls.Add(this.manufacturerIdLbl);
            this.Controls.Add(this.manufacturerDeleteBtn);
            this.Controls.Add(this.manufacturerResetBtn);
            this.Controls.Add(this.manufacturerAddBtn);
            this.Name = "Manufacturers";
            this.Text = "Manufacturers";
            this.Load += new System.EventHandler(this.Manufacturers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblManufacturers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button manufacturerAddBtn;
        private System.Windows.Forms.Button manufacturerResetBtn;
        private System.Windows.Forms.Button manufacturerDeleteBtn;
        private System.Windows.Forms.Label manufacturerIdLbl;
        private System.Windows.Forms.Label manufacturerNameLbl;
        private System.Windows.Forms.TextBox manufacturerIdTb;
        private System.Windows.Forms.TextBox manufacturerNameTb;
        private System.Windows.Forms.DataGridView tblManufacturers;
    }
}