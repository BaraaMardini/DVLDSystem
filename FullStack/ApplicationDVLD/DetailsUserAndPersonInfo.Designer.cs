namespace مشروع_كورس_19
{
    partial class DetailsUserAndPersonInfo
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
            this.detailsPersonUser1 = new مشروع_كورس_19.DetailsPersonUser();
            this.SuspendLayout();
            // 
            // detailsPersonUser1
            // 
            this.detailsPersonUser1.Location = new System.Drawing.Point(83, 12);
            this.detailsPersonUser1.Name = "detailsPersonUser1";
            this.detailsPersonUser1.PersonID = 0;
            this.detailsPersonUser1.Size = new System.Drawing.Size(1260, 751);
            this.detailsPersonUser1.TabIndex = 0;
            this.detailsPersonUser1.Load += new System.EventHandler(this.detailsPersonUser1_Load);
            // 
            // DetailsUserAndPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 848);
            this.Controls.Add(this.detailsPersonUser1);
            this.Name = "DetailsUserAndPersonInfo";
            this.Text = "DetailsUserAndPersonInfo";
            this.Load += new System.EventHandler(this.DetailsUserAndPersonInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DetailsPersonUser detailsPersonAndUserInfo1;
        private DetailsPersonUser detailsPersonUser1;
    }
}