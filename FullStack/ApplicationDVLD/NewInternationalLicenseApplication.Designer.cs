namespace مشروع_كورس_19
{
    partial class NewInternationalLicenseApplication
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
            this.ShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.ShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.BtClose = new System.Windows.Forms.Button();
            this.BtIssue = new System.Windows.Forms.Button();
            this.applicationInfo1 = new مشروع_كورس_19.ApplicationInfo();
            this.filterLicense1 = new مشروع_كورس_19.FilterLicense();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 605);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Application Info";
            // 
            // ShowLicenseHistory
            // 
            this.ShowLicenseHistory.AutoSize = true;
            this.ShowLicenseHistory.Enabled = false;
            this.ShowLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowLicenseHistory.Location = new System.Drawing.Point(141, 858);
            this.ShowLicenseHistory.Name = "ShowLicenseHistory";
            this.ShowLicenseHistory.Size = new System.Drawing.Size(152, 18);
            this.ShowLicenseHistory.TabIndex = 5;
            this.ShowLicenseHistory.TabStop = true;
            this.ShowLicenseHistory.Text = "Show License History";
            this.ShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowLicenseHistory_LinkClicked);
            // 
            // ShowLicenseInfo
            // 
            this.ShowLicenseInfo.AutoSize = true;
            this.ShowLicenseInfo.Enabled = false;
            this.ShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowLicenseInfo.Location = new System.Drawing.Point(328, 858);
            this.ShowLicenseInfo.Name = "ShowLicenseInfo";
            this.ShowLicenseInfo.Size = new System.Drawing.Size(129, 18);
            this.ShowLicenseInfo.TabIndex = 6;
            this.ShowLicenseInfo.TabStop = true;
            this.ShowLicenseInfo.Text = "Show License Info";
            this.ShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowLicenseInfo_LinkClicked);
            // 
            // BtClose
            // 
            this.BtClose.Location = new System.Drawing.Point(696, 858);
            this.BtClose.Name = "BtClose";
            this.BtClose.Size = new System.Drawing.Size(105, 43);
            this.BtClose.TabIndex = 7;
            this.BtClose.Text = "Close";
            this.BtClose.UseVisualStyleBackColor = true;
            this.BtClose.Click += new System.EventHandler(this.BtClose_Click);
            // 
            // BtIssue
            // 
            this.BtIssue.Enabled = false;
            this.BtIssue.Location = new System.Drawing.Point(868, 858);
            this.BtIssue.Name = "BtIssue";
            this.BtIssue.Size = new System.Drawing.Size(105, 43);
            this.BtIssue.TabIndex = 8;
            this.BtIssue.Text = "Issue";
            this.BtIssue.UseVisualStyleBackColor = true;
            this.BtIssue.Click += new System.EventHandler(this.button2_Click);
            // 
            // applicationInfo1
            // 
            this.applicationInfo1.Location = new System.Drawing.Point(144, 618);
            this.applicationInfo1.Name = "applicationInfo1";
            this.applicationInfo1.Size = new System.Drawing.Size(829, 225);
            this.applicationInfo1.TabIndex = 3;
            // 
            // filterLicense1
            // 
            this.filterLicense1.Location = new System.Drawing.Point(45, 12);
            this.filterLicense1.Name = "filterLicense1";
            this.filterLicense1.Size = new System.Drawing.Size(1073, 563);
            this.filterLicense1.TabIndex = 2;
            this.filterLicense1.Load += new System.EventHandler(this.filterLicense1_Load);
            // 
            // NewInternationalLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 983);
            this.Controls.Add(this.BtIssue);
            this.Controls.Add(this.BtClose);
            this.Controls.Add(this.ShowLicenseInfo);
            this.Controls.Add(this.ShowLicenseHistory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.applicationInfo1);
            this.Controls.Add(this.filterLicense1);
            this.Name = "NewInternationalLicenseApplication";
            this.Text = "NewInternationalLicenseApplication";
            this.Load += new System.EventHandler(this.NewInternationalLicenseApplication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FilterLicense filterLicense1;
        private ApplicationInfo applicationInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel ShowLicenseHistory;
        private System.Windows.Forms.LinkLabel ShowLicenseInfo;
        private System.Windows.Forms.Button BtClose;
        private System.Windows.Forms.Button BtIssue;
    }
}