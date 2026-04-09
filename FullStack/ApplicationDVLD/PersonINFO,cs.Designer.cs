namespace مشروع_كورس_19
{
    partial class PersonINFO_cs
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
            this.personDetails1 = new مشروع_كورس_19.PersonDetails();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(408, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Person Details";
            // 
            // personDetails1
            // 
            this.personDetails1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personDetails1.Location = new System.Drawing.Point(12, 79);
            this.personDetails1.Name = "personDetails1";
            this.personDetails1.NationalNO = null;
            this.personDetails1.PersonID = 0;
            this.personDetails1.PersonID2 = 0;
            this.personDetails1.Size = new System.Drawing.Size(1130, 687);
            this.personDetails1.TabIndex = 1;
            // 
            // PersonINFO_cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 778);
            this.Controls.Add(this.personDetails1);
            this.Controls.Add(this.label1);
            this.Name = "PersonINFO_cs";
            this.Text = "PersonINFO_cs";
            this.Load += new System.EventHandler(this.PersonINFO_cs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private PersonDetails personDetails1;
    }
}