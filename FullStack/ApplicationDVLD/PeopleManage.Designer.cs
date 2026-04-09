namespace مشروع_كورس_19
{
    partial class PeopleManage
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.CbFilter = new System.Windows.Forms.ComboBox();
            this.TbFilter = new System.Windows.Forms.TextBox();
            this.PbAddNewPerson = new System.Windows.Forms.PictureBox();
            this.ShowPersonDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdatePerson = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletePerson = new System.Windows.Forms.ToolStripMenuItem();
            this.addPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbAddNewPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(707, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage People";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(23, 387);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1906, 348);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowPersonDetails,
            this.UpdatePerson,
            this.DeletePerson,
            this.addPersonToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 108);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(325, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filter By:";
            // 
            // CbFilter
            // 
            this.CbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilter.FormattingEnabled = true;
            this.CbFilter.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National No",
            "First Name",
            "Second Name",
            "ThirdName",
            "Last Name",
            "Nationalty",
            "Gendor",
            "Phone",
            "Email"});
            this.CbFilter.Location = new System.Drawing.Point(450, 320);
            this.CbFilter.Name = "CbFilter";
            this.CbFilter.Size = new System.Drawing.Size(121, 24);
            this.CbFilter.TabIndex = 4;
            this.CbFilter.SelectedIndexChanged += new System.EventHandler(this.CbFilter_SelectedIndexChanged);
            // 
            // TbFilter
            // 
            this.TbFilter.Enabled = false;
            this.TbFilter.Location = new System.Drawing.Point(602, 322);
            this.TbFilter.Name = "TbFilter";
            this.TbFilter.Size = new System.Drawing.Size(148, 22);
            this.TbFilter.TabIndex = 5;
            this.TbFilter.TextChanged += new System.EventHandler(this.TbFilter_TextChanged);
            // 
            // PbAddNewPerson
            // 
            this.PbAddNewPerson.BackgroundImage = global::مشروع_كورس_19.Properties.Resources.Add_Person_72;
            this.PbAddNewPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbAddNewPerson.Location = new System.Drawing.Point(1334, 277);
            this.PbAddNewPerson.Name = "PbAddNewPerson";
            this.PbAddNewPerson.Size = new System.Drawing.Size(135, 82);
            this.PbAddNewPerson.TabIndex = 6;
            this.PbAddNewPerson.TabStop = false;
            this.PbAddNewPerson.Click += new System.EventHandler(this.PbAddNewPerson_Click);
            // 
            // ShowPersonDetails
            // 
            this.ShowPersonDetails.Image = global::مشروع_كورس_19.Properties.Resources.PersonDetails_32;
            this.ShowPersonDetails.Name = "ShowPersonDetails";
            this.ShowPersonDetails.Size = new System.Drawing.Size(168, 26);
            this.ShowPersonDetails.Text = "Show Details";
            this.ShowPersonDetails.Click += new System.EventHandler(this.ShowPersonDetails_Click_1);
            // 
            // UpdatePerson
            // 
            this.UpdatePerson.Image = global::مشروع_كورس_19.Properties.Resources.edit_32;
            this.UpdatePerson.Name = "UpdatePerson";
            this.UpdatePerson.Size = new System.Drawing.Size(168, 26);
            this.UpdatePerson.Text = "Update";
            this.UpdatePerson.Click += new System.EventHandler(this.UpdatePerson_Click);
            // 
            // DeletePerson
            // 
            this.DeletePerson.Image = global::مشروع_كورس_19.Properties.Resources.Delete_32;
            this.DeletePerson.Name = "DeletePerson";
            this.DeletePerson.Size = new System.Drawing.Size(168, 26);
            this.DeletePerson.Text = "Delete";
            this.DeletePerson.Click += new System.EventHandler(this.DeletePerson_Click);
            // 
            // addPersonToolStripMenuItem
            // 
            this.addPersonToolStripMenuItem.Image = global::مشروع_كورس_19.Properties.Resources.Add_Person_721;
            this.addPersonToolStripMenuItem.Name = "addPersonToolStripMenuItem";
            this.addPersonToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.addPersonToolStripMenuItem.Text = "Add Person";
            this.addPersonToolStripMenuItem.Click += new System.EventHandler(this.addPersonToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::مشروع_كورس_19.Properties.Resources.People_400;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(602, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 184);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PeopleManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1908, 687);
            this.Controls.Add(this.PbAddNewPerson);
            this.Controls.Add(this.TbFilter);
            this.Controls.Add(this.CbFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PeopleManage";
            this.Text = "PeopleManage";
            this.Load += new System.EventHandler(this.PeopleManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbAddNewPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbFilter;
        private System.Windows.Forms.TextBox TbFilter;
        private System.Windows.Forms.PictureBox PbAddNewPerson;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonDetails;
        private System.Windows.Forms.ToolStripMenuItem UpdatePerson;
        private System.Windows.Forms.ToolStripMenuItem DeletePerson;
        private System.Windows.Forms.ToolStripMenuItem addPersonToolStripMenuItem;
    }
}