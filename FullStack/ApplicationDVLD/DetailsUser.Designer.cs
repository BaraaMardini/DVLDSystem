namespace مشروع_كورس_19
{
    partial class DetailsUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.LbIsActive = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LbUserName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LbUserID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID:";
            // 
            // LbIsActive
            // 
            this.LbIsActive.AutoSize = true;
            this.LbIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbIsActive.Location = new System.Drawing.Point(687, 60);
            this.LbIsActive.Name = "LbIsActive";
            this.LbIsActive.Size = new System.Drawing.Size(39, 20);
            this.LbIsActive.TabIndex = 1;
            this.LbIsActive.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(563, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Is Active:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // LbUserName
            // 
            this.LbUserName.AutoSize = true;
            this.LbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUserName.Location = new System.Drawing.Point(436, 60);
            this.LbUserName.Name = "LbUserName";
            this.LbUserName.Size = new System.Drawing.Size(39, 20);
            this.LbUserName.TabIndex = 3;
            this.LbUserName.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(301, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "UserName:";
            // 
            // LbUserID
            // 
            this.LbUserID.AutoSize = true;
            this.LbUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUserID.Location = new System.Drawing.Point(163, 60);
            this.LbUserID.Name = "LbUserID";
            this.LbUserID.Size = new System.Drawing.Size(39, 20);
            this.LbUserID.TabIndex = 5;
            this.LbUserID.Text = "???";
            // 
            // DetailsUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LbUserID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LbUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LbIsActive);
            this.Controls.Add(this.label1);
            this.Name = "DetailsUser";
            this.Size = new System.Drawing.Size(875, 150);
            this.Load += new System.EventHandler(this.DetailsUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbIsActive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LbUserID;
    }
}
