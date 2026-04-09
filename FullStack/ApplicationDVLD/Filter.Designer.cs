namespace مشروع_كورس_19
{
    partial class Filter
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
            this.TbFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbFilter = new System.Windows.Forms.ComboBox();
            this.PbAddNewPerson = new System.Windows.Forms.PictureBox();
            this.PbFindThePerson = new System.Windows.Forms.PictureBox();
            this.personDetails1 = new مشروع_كورس_19.PersonDetails();
            ((System.ComponentModel.ISupportInitialize)(this.PbAddNewPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbFindThePerson)).BeginInit();
            this.SuspendLayout();
            // 
            // TbFilter
            // 
            this.TbFilter.Location = new System.Drawing.Point(325, 30);
            this.TbFilter.Name = "TbFilter";
            this.TbFilter.Size = new System.Drawing.Size(164, 22);
            this.TbFilter.TabIndex = 0;
            this.TbFilter.TextChanged += new System.EventHandler(this.TbFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Find By:";
            // 
            // CbFilter
            // 
            this.CbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilter.FormattingEnabled = true;
            this.CbFilter.Items.AddRange(new object[] {
            "National No.",
            "PersonID"});
            this.CbFilter.Location = new System.Drawing.Point(147, 27);
            this.CbFilter.Name = "CbFilter";
            this.CbFilter.Size = new System.Drawing.Size(121, 24);
            this.CbFilter.TabIndex = 4;
            // 
            // PbAddNewPerson
            // 
            this.PbAddNewPerson.BackgroundImage = global::مشروع_كورس_19.Properties.Resources.Add_Person_40;
            this.PbAddNewPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbAddNewPerson.Location = new System.Drawing.Point(592, 30);
            this.PbAddNewPerson.Name = "PbAddNewPerson";
            this.PbAddNewPerson.Size = new System.Drawing.Size(37, 27);
            this.PbAddNewPerson.TabIndex = 5;
            this.PbAddNewPerson.TabStop = false;
            this.PbAddNewPerson.Click += new System.EventHandler(this.PbAddNewPerson_Click);
            // 
            // PbFindThePerson
            // 
            this.PbFindThePerson.BackgroundImage = global::مشروع_كورس_19.Properties.Resources.SearchPerson;
            this.PbFindThePerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbFindThePerson.Location = new System.Drawing.Point(526, 30);
            this.PbFindThePerson.Name = "PbFindThePerson";
            this.PbFindThePerson.Size = new System.Drawing.Size(37, 27);
            this.PbFindThePerson.TabIndex = 4;
            this.PbFindThePerson.TabStop = false;
            this.PbFindThePerson.Click += new System.EventHandler(this.PbFindThePerson_Click);
            // 
            // personDetails1
            // 
            this.personDetails1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personDetails1.Location = new System.Drawing.Point(26, 84);
            this.personDetails1.Name = "personDetails1";
            this.personDetails1.NationalNO = null;
            this.personDetails1.PersonID = 0;
            this.personDetails1.PersonID2 = 0;
            this.personDetails1.Size = new System.Drawing.Size(800, 504);
            this.personDetails1.TabIndex = 6;
            this.personDetails1.Load += new System.EventHandler(this.personDetails1_Load_1);
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.personDetails1);
            this.Controls.Add(this.PbAddNewPerson);
            this.Controls.Add(this.PbFindThePerson);
            this.Controls.Add(this.CbFilter);
            this.Controls.Add(this.TbFilter);
            this.Controls.Add(this.label1);
            this.Name = "Filter";
            this.Size = new System.Drawing.Size(881, 629);
            this.Load += new System.EventHandler(this.Filter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbAddNewPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbFindThePerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbFilter;
        private System.Windows.Forms.PictureBox PbFindThePerson;
        private System.Windows.Forms.PictureBox PbAddNewPerson;
        private PersonDetails personDetails1;
    }
}
