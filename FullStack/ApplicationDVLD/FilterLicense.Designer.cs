namespace مشروع_كورس_19
{
    partial class FilterLicense
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LbLicenseID = new System.Windows.Forms.Label();
            this.TbFilter = new System.Windows.Forms.TextBox();
            this.driverLicenseInfo1 = new مشروع_كورس_19.DriverLicenseInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::مشروع_كورس_19.Properties.Resources.Driver_License_482;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(432, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 29);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LbLicenseID
            // 
            this.LbLicenseID.AutoSize = true;
            this.LbLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLicenseID.Location = new System.Drawing.Point(112, 22);
            this.LbLicenseID.Name = "LbLicenseID";
            this.LbLicenseID.Size = new System.Drawing.Size(82, 18);
            this.LbLicenseID.TabIndex = 1;
            this.LbLicenseID.Text = "LicenseID";
            // 
            // TbFilter
            // 
            this.TbFilter.Location = new System.Drawing.Point(217, 22);
            this.TbFilter.Name = "TbFilter";
            this.TbFilter.Size = new System.Drawing.Size(193, 22);
            this.TbFilter.TabIndex = 2;
            this.TbFilter.TextChanged += new System.EventHandler(this.TbFilter_TextChanged);
            // 
            // driverLicenseInfo1
            // 
            this.driverLicenseInfo1.Location = new System.Drawing.Point(29, 63);
            this.driverLicenseInfo1.Name = "driverLicenseInfo1";
            this.driverLicenseInfo1.Size = new System.Drawing.Size(1035, 500);
            this.driverLicenseInfo1.TabIndex = 1;
            this.driverLicenseInfo1.Load += new System.EventHandler(this.driverLicenseInfo1_Load);
            // 
            // FilterLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.driverLicenseInfo1);
            this.Controls.Add(this.LbLicenseID);
            this.Controls.Add(this.TbFilter);
            this.Name = "FilterLicense";
            this.Size = new System.Drawing.Size(1101, 596);
            this.Load += new System.EventHandler(this.FilterLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LbLicenseID;
        private System.Windows.Forms.TextBox TbFilter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DriverLicenseInfo driverLicenseInfo1;
    }
}
