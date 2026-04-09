namespace مشروع_كورس_19
{
    partial class LicenseInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtClose = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.driverLicenseInfo1 = new مشروع_كورس_19.DriverLicenseInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(432, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Driver License Info";
            // 
            // BtClose
            // 
            this.BtClose.Location = new System.Drawing.Point(1027, 791);
            this.BtClose.Name = "BtClose";
            this.BtClose.Size = new System.Drawing.Size(133, 56);
            this.BtClose.TabIndex = 5;
            this.BtClose.Text = "Close";
            this.BtClose.UseVisualStyleBackColor = true;
            this.BtClose.Click += new System.EventHandler(this.BtClose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::مشروع_كورس_19.Properties.Resources.Close_643;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(1038, 804);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 33);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::مشروع_كورس_19.Properties.Resources.LicenseView_4002;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(438, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 118);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // driverLicenseInfo1
            // 
            this.driverLicenseInfo1.Location = new System.Drawing.Point(52, 196);
            this.driverLicenseInfo1.Name = "driverLicenseInfo1";
            this.driverLicenseInfo1.Size = new System.Drawing.Size(1108, 577);
            this.driverLicenseInfo1.TabIndex = 7;
            this.driverLicenseInfo1.Load += new System.EventHandler(this.driverLicenseInfo1_Load_1);
            // 
            // LicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 859);
            this.Controls.Add(this.driverLicenseInfo1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "LicenseInfo";
            this.Text = "LicenseInfo";
            this.Load += new System.EventHandler(this.LicenseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtClose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DriverLicenseInfo driverLicenseInfo1;
    }
}