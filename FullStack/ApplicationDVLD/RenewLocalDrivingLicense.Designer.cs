namespace مشروع_كورس_19
{
    partial class RenewLocalDrivingLicense
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
            this.BtIssue = new System.Windows.Forms.Button();
            this.BtClose = new System.Windows.Forms.Button();
            this.ShowNewLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.ShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.applicationNewLicenseInfo1 = new مشروع_كورس_19.ApplicationNewLicenseInfo();
            this.filterLicense1 = new مشروع_كورس_19.FilterLicense();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtIssue
            // 
            this.BtIssue.Enabled = false;
            this.BtIssue.Location = new System.Drawing.Point(772, 920);
            this.BtIssue.Name = "BtIssue";
            this.BtIssue.Size = new System.Drawing.Size(111, 43);
            this.BtIssue.TabIndex = 12;
            this.BtIssue.Text = "Issue";
            this.BtIssue.UseVisualStyleBackColor = true;
            this.BtIssue.Click += new System.EventHandler(this.BtIssue_Click);
            // 
            // BtClose
            // 
            this.BtClose.Location = new System.Drawing.Point(612, 920);
            this.BtClose.Name = "BtClose";
            this.BtClose.Size = new System.Drawing.Size(109, 43);
            this.BtClose.TabIndex = 11;
            this.BtClose.Text = "Close";
            this.BtClose.UseVisualStyleBackColor = true;
            this.BtClose.Click += new System.EventHandler(this.BtClose_Click);
            // 
            // ShowNewLicenseInfo
            // 
            this.ShowNewLicenseInfo.AutoSize = true;
            this.ShowNewLicenseInfo.Enabled = false;
            this.ShowNewLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowNewLicenseInfo.Location = new System.Drawing.Point(340, 931);
            this.ShowNewLicenseInfo.Name = "ShowNewLicenseInfo";
            this.ShowNewLicenseInfo.Size = new System.Drawing.Size(163, 18);
            this.ShowNewLicenseInfo.TabIndex = 10;
            this.ShowNewLicenseInfo.TabStop = true;
            this.ShowNewLicenseInfo.Text = "Show New License Info";
            this.ShowNewLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowNewLicenseInfo_LinkClicked);
            // 
            // ShowLicenseHistory
            // 
            this.ShowLicenseHistory.AutoSize = true;
            this.ShowLicenseHistory.Enabled = false;
            this.ShowLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowLicenseHistory.Location = new System.Drawing.Point(146, 931);
            this.ShowLicenseHistory.Name = "ShowLicenseHistory";
            this.ShowLicenseHistory.Size = new System.Drawing.Size(152, 18);
            this.ShowLicenseHistory.TabIndex = 9;
            this.ShowLicenseHistory.TabStop = true;
            this.ShowLicenseHistory.Text = "Show License History";
            this.ShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowLicenseHistory_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::مشروع_كورس_19.Properties.Resources.cross_32;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(622, 931);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 21);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::مشروع_كورس_19.Properties.Resources.Renew_Driving_License_32;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(782, 931);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 21);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // applicationNewLicenseInfo1
            // 
            this.applicationNewLicenseInfo1.Location = new System.Drawing.Point(116, 558);
            this.applicationNewLicenseInfo1.Name = "applicationNewLicenseInfo1";
            this.applicationNewLicenseInfo1.Size = new System.Drawing.Size(842, 344);
            this.applicationNewLicenseInfo1.TabIndex = 15;
            // 
            // filterLicense1
            // 
            this.filterLicense1.Location = new System.Drawing.Point(12, 12);
            this.filterLicense1.Name = "filterLicense1";
            this.filterLicense1.Size = new System.Drawing.Size(1085, 549);
            this.filterLicense1.TabIndex = 0;
            // 
            // RenewLocalDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 1055);
            this.Controls.Add(this.applicationNewLicenseInfo1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtIssue);
            this.Controls.Add(this.BtClose);
            this.Controls.Add(this.ShowNewLicenseInfo);
            this.Controls.Add(this.ShowLicenseHistory);
            this.Controls.Add(this.filterLicense1);
            this.Name = "RenewLocalDrivingLicense";
            this.Text = "RenewLocalDrivingLicense";
            this.Load += new System.EventHandler(this.RenewLocalDrivingLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FilterLicense filterLicense1;
        private System.Windows.Forms.Button BtIssue;
        private System.Windows.Forms.Button BtClose;
        private System.Windows.Forms.LinkLabel ShowNewLicenseInfo;
        private System.Windows.Forms.LinkLabel ShowLicenseHistory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ApplicationNewLicenseInfo applicationNewLicenseInfo1;
    }
}