namespace MobileManagement.UI
{
    partial class Report
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
            this.usersCb = new System.Windows.Forms.ComboBox();
            this.tblDevices = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tblDevices)).BeginInit();
            this.SuspendLayout();
            // 
            // usersCb
            // 
            this.usersCb.FormattingEnabled = true;
            this.usersCb.Location = new System.Drawing.Point(13, 13);
            this.usersCb.Name = "usersCb";
            this.usersCb.Size = new System.Drawing.Size(727, 21);
            this.usersCb.TabIndex = 0;
            this.usersCb.SelectedIndexChanged += new System.EventHandler(this.usersCb_SelectedIndexChanged);
            // 
            // tblDevices
            // 
            this.tblDevices.AllowUserToAddRows = false;
            this.tblDevices.AllowUserToDeleteRows = false;
            this.tblDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDevices.Location = new System.Drawing.Point(13, 49);
            this.tblDevices.Name = "tblDevices";
            this.tblDevices.ReadOnly = true;
            this.tblDevices.Size = new System.Drawing.Size(727, 305);
            this.tblDevices.TabIndex = 1;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 366);
            this.Controls.Add(this.tblDevices);
            this.Controls.Add(this.usersCb);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblDevices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox usersCb;
        private System.Windows.Forms.DataGridView tblDevices;
    }
}