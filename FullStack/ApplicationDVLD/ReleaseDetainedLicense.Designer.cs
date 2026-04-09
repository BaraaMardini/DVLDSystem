namespace مشروع_كورس_19
{
    partial class ReleaseDetainedLicense
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
            this.filterLicense1 = new مشروع_كورس_19.FilterLicense();
            this.BtRelease = new System.Windows.Forms.Button();
            this.BtClose = new System.Windows.Forms.Button();
            this.ShowNewLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.ShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.detainInfo21 = new مشروع_كورس_19.DetainInfo2();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // filterLicense1
            // 
            this.filterLicense1.Location = new System.Drawing.Point(25, 12);
            this.filterLicense1.Name = "filterLicense1";
            this.filterLicense1.Size = new System.Drawing.Size(1072, 552);
            this.filterLicense1.TabIndex = 0;
            this.filterLicense1.Load += new System.EventHandler(this.filterLicense1_Load);
            // 
            // BtRelease
            // 
            this.BtRelease.Enabled = false;
            this.BtRelease.Location = new System.Drawing.Point(864, 808);
            this.BtRelease.Name = "BtRelease";
            this.BtRelease.Size = new System.Drawing.Size(119, 43);
            this.BtRelease.TabIndex = 30;
            this.BtRelease.Text = "Release";
            this.BtRelease.UseVisualStyleBackColor = true;
            this.BtRelease.Click += new System.EventHandler(this.BtRelease_Click);
            // 
            // BtClose
            // 
            this.BtClose.Location = new System.Drawing.Point(721, 808);
            this.BtClose.Name = "BtClose";
            this.BtClose.Size = new System.Drawing.Size(109, 43);
            this.BtClose.TabIndex = 29;
            this.BtClose.Text = "Close";
            this.BtClose.UseVisualStyleBackColor = true;
            this.BtClose.Click += new System.EventHandler(this.BtClose_Click);
            // 
            // ShowNewLicenseInfo
            // 
            this.ShowNewLicenseInfo.AutoSize = true;
            this.ShowNewLicenseInfo.Enabled = false;
            this.ShowNewLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowNewLicenseInfo.Location = new System.Drawing.Point(311, 819);
            this.ShowNewLicenseInfo.Name = "ShowNewLicenseInfo";
            this.ShowNewLicenseInfo.Size = new System.Drawing.Size(163, 18);
            this.ShowNewLicenseInfo.TabIndex = 28;
            this.ShowNewLicenseInfo.TabStop = true;
            this.ShowNewLicenseInfo.Text = "Show New License Info";
            this.ShowNewLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowNewLicenseInfo_LinkClicked);
            // 
            // ShowLicenseHistory
            // 
            this.ShowLicenseHistory.AutoSize = true;
            this.ShowLicenseHistory.Enabled = false;
            this.ShowLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowLicenseHistory.Location = new System.Drawing.Point(118, 816);
            this.ShowLicenseHistory.Name = "ShowLicenseHistory";
            this.ShowLicenseHistory.Size = new System.Drawing.Size(152, 18);
            this.ShowLicenseHistory.TabIndex = 27;
            this.ShowLicenseHistory.TabStop = true;
            this.ShowLicenseHistory.Text = "Show License History";
            this.ShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowLicenseHistory_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::مشروع_كورس_19.Properties.Resources.cross_32;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(731, 819);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 21);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::مشروع_كورس_19.Properties.Resources.Release_Detained_License_321;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(876, 819);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 21);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // detainInfo21
            // 
            this.detainInfo21.Location = new System.Drawing.Point(121, 561);
            this.detainInfo21.Name = "detainInfo21";
            this.detainInfo21.Size = new System.Drawing.Size(873, 241);
            this.detainInfo21.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 561);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Detain Info";
            // 
            // ReleaseDetainedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 875);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.detainInfo21);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtRelease);
            this.Controls.Add(this.BtClose);
            this.Controls.Add(this.ShowNewLicenseInfo);
            this.Controls.Add(this.ShowLicenseHistory);
            this.Controls.Add(this.filterLicense1);
            this.Name = "ReleaseDetainedLicense";
            this.Text = "ReleaseDetainedLicense";
            this.Load += new System.EventHandler(this.ReleaseDetainedLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FilterLicense filterLicense1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtRelease;
        private System.Windows.Forms.Button BtClose;
        private System.Windows.Forms.LinkLabel ShowNewLicenseInfo;
        private System.Windows.Forms.LinkLabel ShowLicenseHistory;
        private DetainInfo2 detainInfo21;
        private System.Windows.Forms.Label label2;
    }
}