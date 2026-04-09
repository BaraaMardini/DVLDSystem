namespace مشروع_كورس_19
{
    partial class DetailsLocalDrivingApplication
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
            this.SuspendLayout();
            // 
            // localDriveApplicationDetails1
            // 
            this.localDriveApplicationDetails1.Location = new System.Drawing.Point(42, 98);
            this.localDriveApplicationDetails1.Name = "localDriveApplicationDetails1";
            this.localDriveApplicationDetails1.Size = new System.Drawing.Size(1014, 460);
            this.localDriveApplicationDetails1.TabIndex = 2;
            // 
            // DetailsLocalDrivingApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 646);
            this.Controls.Add(this.localDriveApplicationDetails1);
            this.Name = "DetailsLocalDrivingApplication";
            this.Text = "DetailsLocalDrivingApplication";
            this.Load += new System.EventHandler(this.DetailsLocalDrivingApplication_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LocalDriveApplicationDetails localDriveApplicationDetails1;
    }
}