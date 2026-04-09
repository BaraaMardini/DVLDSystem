namespace مشروع_كورس_19
{
    partial class ReplacementForDamagedLicense
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbLostLicense = new System.Windows.Forms.RadioButton();
            this.RbDamagedLicense = new System.Windows.Forms.RadioButton();
            this.BtIssue = new System.Windows.Forms.Button();
            this.BtClose = new System.Windows.Forms.Button();
            this.ShowNewLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.ShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.applicationInfoForLicenseReplacement1 = new مشروع_كورس_19.ApplicationInfoForLicenseReplacement();
            this.filterLicense1 = new مشروع_كورس_19.FilterLicense();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(368, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Replacement For Damaged License";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbLostLicense);
            this.groupBox1.Controls.Add(this.RbDamagedLicense);
            this.groupBox1.Location = new System.Drawing.Point(886, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Replacement For:";
            // 
            // RbLostLicense
            // 
            this.RbLostLicense.AutoSize = true;
            this.RbLostLicense.Location = new System.Drawing.Point(11, 58);
            this.RbLostLicense.Name = "RbLostLicense";
            this.RbLostLicense.Size = new System.Drawing.Size(103, 20);
            this.RbLostLicense.TabIndex = 3;
            this.RbLostLicense.TabStop = true;
            this.RbLostLicense.Text = "Lost License";
            this.RbLostLicense.UseVisualStyleBackColor = true;
            this.RbLostLicense.CheckedChanged += new System.EventHandler(this.RbLostLicense_CheckedChanged);
            // 
            // RbDamagedLicense
            // 
            this.RbDamagedLicense.AutoSize = true;
            this.RbDamagedLicense.Location = new System.Drawing.Point(11, 21);
            this.RbDamagedLicense.Name = "RbDamagedLicense";
            this.RbDamagedLicense.Size = new System.Drawing.Size(139, 20);
            this.RbDamagedLicense.TabIndex = 4;
            this.RbDamagedLicense.TabStop = true;
            this.RbDamagedLicense.Text = "Damaged License";
            this.RbDamagedLicense.UseVisualStyleBackColor = true;
            this.RbDamagedLicense.CheckedChanged += new System.EventHandler(this.RbDamagedLicense_CheckedChanged);
            // 
            // BtIssue
            // 
            this.BtIssue.Enabled = false;
            this.BtIssue.Location = new System.Drawing.Point(897, 827);
            this.BtIssue.Name = "BtIssue";
            this.BtIssue.Size = new System.Drawing.Size(195, 43);
            this.BtIssue.TabIndex = 18;
            this.BtIssue.Text = "Issue Replacement";
            this.BtIssue.UseVisualStyleBackColor = true;
            this.BtIssue.Click += new System.EventHandler(this.BtIssue_Click);
            // 
            // BtClose
            // 
            this.BtClose.Location = new System.Drawing.Point(755, 824);
            this.BtClose.Name = "BtClose";
            this.BtClose.Size = new System.Drawing.Size(109, 43);
            this.BtClose.TabIndex = 17;
            this.BtClose.Text = "Close";
            this.BtClose.UseVisualStyleBackColor = true;
            this.BtClose.Click += new System.EventHandler(this.BtClose_Click);
            // 
            // ShowNewLicenseInfo
            // 
            this.ShowNewLicenseInfo.AutoSize = true;
            this.ShowNewLicenseInfo.Enabled = false;
            this.ShowNewLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowNewLicenseInfo.Location = new System.Drawing.Point(404, 838);
            this.ShowNewLicenseInfo.Name = "ShowNewLicenseInfo";
            this.ShowNewLicenseInfo.Size = new System.Drawing.Size(163, 18);
            this.ShowNewLicenseInfo.TabIndex = 16;
            this.ShowNewLicenseInfo.TabStop = true;
            this.ShowNewLicenseInfo.Text = "Show New License Info";
            this.ShowNewLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowNewLicenseInfo_LinkClicked);
            // 
            // ShowLicenseHistory
            // 
            this.ShowLicenseHistory.AutoSize = true;
            this.ShowLicenseHistory.Enabled = false;
            this.ShowLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowLicenseHistory.Location = new System.Drawing.Point(210, 838);
            this.ShowLicenseHistory.Name = "ShowLicenseHistory";
            this.ShowLicenseHistory.Size = new System.Drawing.Size(152, 18);
            this.ShowLicenseHistory.TabIndex = 15;
            this.ShowLicenseHistory.TabStop = true;
            this.ShowLicenseHistory.Text = "Show License History";
            this.ShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowLicenseHistory_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::مشروع_كورس_19.Properties.Resources.cross_32;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(765, 835);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 21);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::مشروع_كورس_19.Properties.Resources.Renew_Driving_License_32;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(911, 838);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 21);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 636);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Application Info For License Replacement";
            // 
            // applicationInfoForLicenseReplacement1
            // 
            this.applicationInfoForLicenseReplacement1.Location = new System.Drawing.Point(156, 655);
            this.applicationInfoForLicenseReplacement1.Name = "applicationInfoForLicenseReplacement1";
            this.applicationInfoForLicenseReplacement1.Size = new System.Drawing.Size(828, 163);
            this.applicationInfoForLicenseReplacement1.TabIndex = 21;
            // 
            // filterLicense1
            // 
            this.filterLicense1.Location = new System.Drawing.Point(77, 68);
            this.filterLicense1.Name = "filterLicense1";
            this.filterLicense1.Size = new System.Drawing.Size(1071, 555);
            this.filterLicense1.TabIndex = 1;
            // 
            // ReplacementForDamagedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 909);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.applicationInfoForLicenseReplacement1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtIssue);
            this.Controls.Add(this.BtClose);
            this.Controls.Add(this.ShowNewLicenseInfo);
            this.Controls.Add(this.ShowLicenseHistory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.filterLicense1);
            this.Controls.Add(this.label1);
            this.Name = "ReplacementForDamagedLicense";
            this.Text = "ReplacementForDamagedLicense";
            this.Load += new System.EventHandler(this.ReplacementForDamagedLicense_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FilterLicense filterLicense1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbLostLicense;
        private System.Windows.Forms.RadioButton RbDamagedLicense;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtIssue;
        private System.Windows.Forms.Button BtClose;
        private System.Windows.Forms.LinkLabel ShowNewLicenseInfo;
        private System.Windows.Forms.LinkLabel ShowLicenseHistory;
        private ApplicationInfoForLicenseReplacement applicationInfoForLicenseReplacement1;
        private System.Windows.Forms.Label label2;
    }
}