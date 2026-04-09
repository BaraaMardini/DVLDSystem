namespace مشروع_كورس_19
{
    partial class IssueDriverLicense
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
            this.localDriveApplicationDetails1 = new مشروع_كورس_19.LocalDriveApplicationDetails();
            this.TbNotes = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtSave = new System.Windows.Forms.Button();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.BtClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // localDriveApplicationDetails1
            // 
            this.localDriveApplicationDetails1.Location = new System.Drawing.Point(64, 52);
            this.localDriveApplicationDetails1.Name = "localDriveApplicationDetails1";
            this.localDriveApplicationDetails1.Size = new System.Drawing.Size(1073, 460);
            this.localDriveApplicationDetails1.TabIndex = 0;
            this.localDriveApplicationDetails1.Load += new System.EventHandler(this.localDriveApplicationDetails1_Load);
            // 
            // TbNotes
            // 
            this.TbNotes.Location = new System.Drawing.Point(228, 516);
            this.TbNotes.Name = "TbNotes";
            this.TbNotes.Size = new System.Drawing.Size(857, 159);
            this.TbNotes.TabIndex = 86;
            this.TbNotes.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(97, 515);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 84;
            this.label6.Text = "Notes:";
            // 
            // BtSave
            // 
            this.BtSave.Location = new System.Drawing.Point(969, 691);
            this.BtSave.Name = "BtSave";
            this.BtSave.Size = new System.Drawing.Size(116, 56);
            this.BtSave.TabIndex = 87;
            this.BtSave.Text = "Save";
            this.BtSave.UseVisualStyleBackColor = true;
            this.BtSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImage = global::مشروع_كورس_19.Properties.Resources.Save_321;
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox11.Location = new System.Drawing.Point(977, 705);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(30, 29);
            this.pictureBox11.TabIndex = 88;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = global::مشروع_كورس_19.Properties.Resources.Notes_32;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox9.Location = new System.Drawing.Point(172, 516);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(26, 19);
            this.pictureBox9.TabIndex = 85;
            this.pictureBox9.TabStop = false;
            // 
            // BtClose
            // 
            this.BtClose.Location = new System.Drawing.Point(782, 691);
            this.BtClose.Name = "BtClose";
            this.BtClose.Size = new System.Drawing.Size(133, 56);
            this.BtClose.TabIndex = 89;
            this.BtClose.Text = "Close";
            this.BtClose.UseVisualStyleBackColor = true;
            this.BtClose.Click += new System.EventHandler(this.BtClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::مشروع_كورس_19.Properties.Resources.Close_32;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(793, 705);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 29);
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // IssueDriverLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 792);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtClose);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.BtSave);
            this.Controls.Add(this.TbNotes);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.localDriveApplicationDetails1);
            this.Name = "IssueDriverLicense";
            this.Text = "IssueDriverLicense";
            this.Load += new System.EventHandler(this.IssueDriverLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LocalDriveApplicationDetails localDriveApplicationDetails1;
        private System.Windows.Forms.RichTextBox TbNotes;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Button BtSave;
        private System.Windows.Forms.Button BtClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}