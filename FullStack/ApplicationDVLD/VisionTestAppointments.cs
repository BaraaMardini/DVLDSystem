using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestAppointmentBusinessLayer;

namespace مشروع_كورس_19
{
    public partial class VisionTestAppointments : Form
    {

        int LocalDriveApplicationID;
        int TestTypeID;
        string ClassName;
        public VisionTestAppointments(int LocalDriveApplicationID, int TestTypeID, string ClassName)
        {
            InitializeComponent();
            this.LocalDriveApplicationID = LocalDriveApplicationID;
            this.TestTypeID = TestTypeID;
            this.ClassName = ClassName;
        }
        private bool CheakTypeOfTest()
        {

            if (TestTypeID == 2) {
                this.Text = "Written Test Appointment";
                pictureBox1.BackgroundImage = PictureWritten.BackgroundImage;

                LbNameOfTypeTest.Text = "Written Test Appointment";
                return true;
            }
            if (TestTypeID == 3)
            {
                this.Text = "Drive Test Appointment";
                pictureBox1.BackgroundImage = PictureDriving.BackgroundImage;
                LbNameOfTypeTest.Text = "Drive Test Appointment";

                return true;
            }



            return true;
        }

        private void StoreTheDataInDataGridVirw()
        {

            dataGridView1.DataSource = TestAppointment.GetTestAppointmentByLocalDrivingLicenseApplicationID(LocalDriveApplicationID, TestTypeID);
        }
        private void VisionTestAppointments_Load(object sender, EventArgs e)
        {


            CheakTypeOfTest();
            localDriveApplicationDetails1.LocalDriveApplicationID = LocalDriveApplicationID;

            localDriveApplicationDetails1.UpdateDisplay();

            StoreTheDataInDataGridVirw();

        }
        private void AddNewAppointment()
        {
            if (TestAppointment.IsTestTypeActive(0, TestTypeID, ClassName, LocalDriveApplicationID))
            {
                MessageBox.Show(
               "Person Already have an active appointment for this test, You cannot add new appointment",
                     "Not allowed",
             MessageBoxButtons.OK,
            MessageBoxIcon.Error
     );

            }
            else
            {

                ScheduleTest frm = new ScheduleTest(0, LocalDriveApplicationID, TestTypeID, ClassName);
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
        }
        private void PbAddNewAppointment_Click(object sender, EventArgs e)
        {

            if (TestAppointment.GetLastPassedTestAppointmentID(1, LocalDriveApplicationID,TestTypeID)) 
            {
                MessageBox.Show(
               "Person Already have an active appointment for this test, You cannot add new appointment",
                     "Not allowed");



            }
            else
            {
                AddNewAppointment();
                StoreTheDataInDataGridVirw();
            }

        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TakeTest frm = new TakeTest((int)dataGridView1.CurrentRow.Cells[0].Value, LocalDriveApplicationID, TestTypeID);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            StoreTheDataInDataGridVirw();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if ((bool)dataGridView1.CurrentRow.Cells[3].Value == true){


                takeTestToolStripMenuItem.Enabled = false;
            }
            else
            {
           
                takeTestToolStripMenuItem.Enabled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
