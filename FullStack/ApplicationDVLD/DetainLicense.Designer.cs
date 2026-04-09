namespace مشروع_كورس_19
{
    partial class DetainLicense
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
            this.BtDetain = new System.Windows.Forms.Button();
            this.BtClose = new System.Windows.Forms.Button();
            this.ShowNewLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.ShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.detainInfo1 = new مشروع_كورس_19.DetainInfo();
            this.filterLicense1 = new مشروع_كورس_19.FilterLicense();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(421, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Detain License";
            // 
            // BtDetain
            // 
            this.BtDetain.Enabled = false;
            this.BtDetain.Location = new System.Drawing.Point(863, 811);
            this.BtDetain.Name = "BtDetain";
            this.BtDetain.Size = new System.Drawing.Size(119, 43);
            this.BtDetain.TabIndex = 24;
            this.BtDetain.Text = "Detain";
            this.BtDetain.UseVisualStyleBackColor = true;
            this.BtDetain.Click += new System.EventHandler(this.BtDetain_Click);
            // 
            // BtClose
            // 
            this.BtClose.Location = new System.Drawing.Point(720, 811);
            this.BtClose.Name = "BtClose";
            this.BtClose.Size = new System.Drawing.Size(109, 43);
            this.BtClose.TabIndex = 23;
            this.BtClose.Text = "Close";
            this.BtClose.UseVisualStyleBackColor = true;
            this.BtClose.Click += new System.EventHandler(this.BtClose_Click);
            // 
            // ShowNewLicenseInfo
            // 
            this.ShowNewLicenseInfo.AutoSize = true;
            this.ShowNewLicenseInfo.Enabled = false;
            this.ShowNewLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowNewLicenseInfo.Location = new System.Drawing.Point(369, 825);
            this.ShowNewLicenseInfo.Name = "ShowNewLicenseInfo";
            this.ShowNewLicenseInfo.Size = new System.Drawing.Size(163, 18);
            this.ShowNewLicenseInfo.TabIndex = 22;
            this.ShowNewLicenseInfo.TabStop = true;
            this.ShowNewLicenseInfo.Text = "Show New License Info";
            this.ShowNewLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowNewLicenseInfo_LinkClicked);
            // 
            // ShowLicenseHistory
            // 
            this.ShowLicenseHistory.AutoSize = true;
            this.ShowLicenseHistory.Enabled = false;
            this.ShowLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowLicenseHistory.Location = new System.Drawing.Point(175, 825);
            this.ShowLicenseHistory.Name = "ShowLicenseHistory";
            this.ShowLicenseHistory.Size = new System.Drawing.Size(152, 18);
            this.ShowLicenseHistory.TabIndex = 21;
            this.ShowLicenseHistory.TabStop = true;
            this.ShowLicenseHistory.Text = "Show License History";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::مشروع_كورس_19.Properties.Resources.cross_32;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(730, 822);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 21);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::مشروع_كورس_19.Properties.Resources.International_323;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(875, 822);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 21);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // detainInfo1
            // 
            this.detainInfo1.Location = new System.Drawing.Point(144, 632);
            this.detainInfo1.Name = "detainInfo1";
            this.detainInfo1.Size = new System.Drawing.Size(731, 173);
            this.detainInfo1.TabIndex = 27;
            // 
            // filterLicense1
            // 
            this.filterLicense1.Location = new System.Drawing.Point(12, 77);
            this.filterLicense1.Name = "filterLicense1";
            this.filterLicense1.Size = new System.Drawing.Size(1101, 558);
            this.filterLicense1.TabIndex = 0;
            this.filterLicense1.Load += new System.EventHandler(this.filterLicense1_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 619);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Detain Info";
            // 
            // DetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 877);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.detainInfo1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtDetain);
            this.Controls.Add(this.BtClose);
            this.Controls.Add(this.ShowNewLicenseInfo);
            this.Controls.Add(this.ShowLicenseHistory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterLicense1);
            this.Name = "DetainLicense";
            this.Text = "DetainLicense";
            this.Load += new System.EventHandler(this.DetainLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FilterLicense filterLicense1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtDetain;
        private System.Windows.Forms.Button BtClose;
        private System.Windows.Forms.LinkLabel ShowNewLicenseInfo;
        private System.Windows.Forms.LinkLabel ShowLicenseHistory;
        private DetainInfo detainInfo1;
        private System.Windows.Forms.Label label2;
    }
}