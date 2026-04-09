using DVLDBusinessLayer;
using LocalDrivingApplicationBusinessLayer;
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
using TestBusinessLayer;
using UserBusinessLayer;

namespace مشروع_كورس_19
{
    public partial class TakeTest : Form
    {

        int AppointmentID;
        int LocalDriveApplicationID;
        int TestTypeID;
        public TakeTest(int AppointmentID, int LocalDriveApplicationID,int TestTypeID)
        {
            InitializeComponent();

            this.LocalDriveApplicationID = LocalDriveApplicationID;
          this.AppointmentID = AppointmentID;
            this.TestTypeID = TestTypeID;
        }
        private  bool StoreThePictureInControl()
        {
            if (TestTypeID == 2)
            {
                this.Text = "Written Test Appointment";
                pictureBox1.BackgroundImage = PictureWritten.BackgroundImage;

                LbScheduleTest.Text = "Written Test Appointment";
                groupBox1.Text = "Written Test Appointment";
                return true;
       
            }
            if (TestTypeID == 3)
            {
                this.Text = "Drive Test Appointment";
                pictureBox1.BackgroundImage = PictureDriving.BackgroundImage;

                LbScheduleTest.Text = "Drive Test Appointment";
                groupBox1.Text = "Drive Test Appointment";

                return true;
            }

            return true;

        }
        private void SaveTheTestAppointment()
        {
            int PassOrFail = 0;
            if (RbPass.Checked == true)
            {
                PassOrFail = 1;
            }
            else
            {
                PassOrFail = 0;
            }

            Test.AddNewTest(AppointmentID, PassOrFail, TbNotes.Text, User.GetUserIDByUserNameAndPassword(UserInfo.UserName,UserInfo.Password));



        }
        private void StoreTheDataInControl()
        {

            DataTable dt = DVLD.GetAllLocalDrivingLicenseApplications(LocalDriveApplicationID);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                LbLocalDriveApplicationID.Text = row[0].ToString();

                LbClassName.Text = row[4].ToString();

                LbName.Text = row[8].ToString();

            }
            else
            {
                MessageBox.Show("لا توجد بيانات للطلب المطلوب.");




            }
            LbDate.Text=TestAppointment.GetAppointmentDateByAppointmentID(AppointmentID).ToString();
            LbFees.Text = Test.GetFeesTypeByTestTypeID(TestTypeID).ToString();

        }
        private void TakeTest_Load(object sender, EventArgs e)
        {
            StoreTheDataInControl();
            StoreThePictureInControl();
        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            SaveTheTestAppointment();
            TestAppointment.UpdateTestAppointment(AppointmentID);
            MessageBox.Show(" العملية تمت بنجاح ");
            this.Close();
      

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
