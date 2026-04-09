namespace مشروع_كورس_19
{
    partial class VisionTestAppointments
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
            this.LbNameOfTypeTest = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.LbNumberRecords = new System.Windows.Forms.Label();
            this.PictureDriving = new System.Windows.Forms.PictureBox();
            this.PictureWritten = new System.Windows.Forms.PictureBox();
            this.PbAddNewAppointment = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.localDriveApplicationDetails1 = new مشروع_كورس_19.LocalDriveApplicationDetails();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureDriving)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureWritten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAddNewAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LbNameOfTypeTest
            // 
            this.LbNameOfTypeTest.AutoSize = true;
            this.LbNameOfTypeTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNameOfTypeTest.ForeColor = System.Drawing.Color.Brown;
            this.LbNameOfTypeTest.Location = new System.Drawing.Point(417, 116);
            this.LbNameOfTypeTest.Name = "LbNameOfTypeTest";
            this.LbNameOfTypeTest.Size = new System.Drawing.Size(286, 29);
            this.LbNameOfTypeTest.TabIndex = 0;
            this.LbNameOfTypeTest.Text = "Vision Test Appointments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 630);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Appointments:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(73, 664);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1003, 193);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takeTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(215, 58);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = global::مشروع_كورس_19.Properties.Resources.Test_32;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 873);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "# Records";
            // 
            // LbNumberRecords
            // 
            this.LbNumberRecords.AutoSize = true;
            this.LbNumberRecords.Location = new System.Drawing.Point(166, 873);
            this.LbNumberRecords.Name = "LbNumberRecords";
            this.LbNumberRecords.Size = new System.Drawing.Size(14, 16);
            this.LbNumberRecords.TabIndex = 6;
            this.LbNumberRecords.Text = "1";
            // 
            // PictureDriving
            // 
            this.PictureDriving.BackgroundImage = global::مشروع_كورس_19.Properties.Resources.driving_test_512;
            this.PictureDriving.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureDriving.Location = new System.Drawing.Point(769, 12);
            this.PictureDriving.Name = "PictureDriving";
            this.PictureDriving.Size = new System.Drawing.Size(142, 89);
            this.PictureDriving.TabIndex = 66;
            this.PictureDriving.TabStop = false;
            this.PictureDriving.Visible = false;
            // 
            // PictureWritten
            // 
            this.PictureWritten.BackgroundImage = global::مشروع_كورس_19.Properties.Resources.Written_Test_512;
            this.PictureWritten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureWritten.Location = new System.Drawing.Point(934, 8);
            this.PictureWritten.Name = "PictureWritten";
            this.PictureWritten.Size = new System.Drawing.Size(142, 89);
            this.PictureWritten.TabIndex = 65;
            this.PictureWritten.TabStop = false;
            this.PictureWritten.Visible = false;
            // 
            // PbAddNewAppointment
            // 
            this.PbAddNewAppointment.BackgroundImage = global::مشروع_كورس_19.Properties.Resources.AddAppointment_32;
            this.PbAddNewAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbAddNewAppointment.Location = new System.Drawing.Point(1027, 633);
            this.PbAddNewAppointment.Name = "PbAddNewAppointment";
            this.PbAddNewAppointment.Size = new System.Drawing.Size(49, 28);
            this.PbAddNewAppointment.TabIndex = 7;
            this.PbAddNewAppointment.TabStop = false;
            this.PbAddNewAppointment.Click += new System.EventHandler(this.PbAddNewAppointment_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::مشروع_كورس_19.Properties.Resources.Vision_512;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(480, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 89);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // localDriveApplicationDetails1
            // 
            this.localDriveApplicationDetails1.Location = new System.Drawing.Point(46, 167);
            this.localDriveApplicationDetails1.Name = "localDriveApplicationDetails1";
            this.localDriveApplicationDetails1.Size = new System.Drawing.Size(1030, 460);
            this.localDriveApplicationDetails1.TabIndex = 1;
            // 
            // VisionTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 915);
            this.Controls.Add(this.PictureDriving);
            this.Controls.Add(this.PictureWritten);
            this.Controls.Add(this.PbAddNewAppointment);
            this.Controls.Add(this.LbNumberRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.localDriveApplicationDetails1);
            this.Controls.Add(this.LbNameOfTypeTest);
            this.Name = "VisionTestAppointments";
            this.Text = "Vision Test Appointments";
            this.Load += new System.EventHandler(this.VisionTestAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureDriving)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureWritten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAddNewAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbNameOfTypeTest;
        private LocalDriveApplicationDetails localDriveApplicationDetails1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbNumberRecords;
        private System.Windows.Forms.PictureBox PbAddNewAppointment;
        private System.Windows.Forms.PictureBox PictureDriving;
        private System.Windows.Forms.PictureBox PictureWritten;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}