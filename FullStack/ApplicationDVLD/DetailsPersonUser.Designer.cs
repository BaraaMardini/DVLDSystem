namespace مشروع_كورس_19
{
    partial class DetailsPersonUser
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
            this.personDetails1 = new مشروع_كورس_19.PersonDetails();
            this.detailsUser1 = new مشروع_كورس_19.DetailsUser();
            this.SuspendLayout();
            // 
            // personDetails1
            // 
            this.personDetails1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personDetails1.Location = new System.Drawing.Point(45, 28);
            this.personDetails1.Name = "personDetails1";
            this.personDetails1.NationalNO = null;
            this.personDetails1.PersonID = 0;
            this.personDetails1.PersonID2 = 0;
            this.personDetails1.Size = new System.Drawing.Size(1203, 521);
            this.personDetails1.TabIndex = 0;
            this.personDetails1.Load += new System.EventHandler(this.personDetails1_Load);
            // 
            // detailsUser1
            // 
            this.detailsUser1.Location = new System.Drawing.Point(150, 610);
            this.detailsUser1.Name = "detailsUser1";
            this.detailsUser1.Size = new System.Drawing.Size(875, 111);
            this.detailsUser1.TabIndex = 1;
            // 
            // DetailsPersonUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.detailsUser1);
            this.Controls.Add(this.personDetails1);
            this.Name = "DetailsPersonUser";
            this.Size = new System.Drawing.Size(1260, 751);
            this.Load += new System.EventHandler(this.DetailsPersonAndUserInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PersonDetails personDetails1;
        private DetailsUser detailsUser1;
    }
}
