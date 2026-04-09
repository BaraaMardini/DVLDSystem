using ApplicationBusinessLayer14;
using DVLDBusinessLayer;
using LocalDrivingApplicationBusinessLayer;
using PeopleBusinessLayer1;
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
    public partial class ScheduleTest : Form
    {

        int AppointmentID = 0;
        int LocalDrivingApplicationID = 0;
 
        int TestTypeID = 0;
        string ClassName;
       
        public ScheduleTest(int AppointmentID, int LocalDrivingApplicationID, int TestTypeID, string ClassName)
        {
            InitializeComponent();
            this.AppointmentID = AppointmentID;
            this.LocalDrivingApplicationID= LocalDrivingApplicationID;
         this.TestTypeID = TestTypeID;
           this.ClassName = ClassName;
        }
        private void StoreTheDataInControls()
        {
          //  LbFees.Text = Test.GetFeesTypeByTestTypeID(1).ToString();
            DataTable dt = DVLD.GetAllLocalDrivingLicenseApplications(LocalDrivingApplicationID);

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
            int CountOfAppointmentID = DVLD.CountOfTestRepeat(LocalDrivingApplicationID, TestTypeID);
            
          
            if (CountOfAppointmentID > 0)
            {
               LbRetakeTestID.Text = TestAppointment.GetLastTestAppointmentID(LocalDrivingApplicationID, TestTypeID).ToString();
                int Fees= (int)Application14.GetFeesApplicationByApplicationTypeID(7);
                LbFeesRetakeTest.Text = Application14.GetFeesApplicationByApplicationTypeID(7).ToString();
                groupBox2.Enabled = true;

            }

            if (groupBox2.Enabled == true)
        {
                double Fees = Convert.ToDouble(LbFees.Text);
                double FeesRetake = Convert.ToDouble(LbFeesRetakeTest.Text);
                double LocalFess =Fees+FeesRetake;
                TotalFees.Text = LocalFess.ToString();

            }
            else
            {
                double LocalFees = Convert.ToDouble(LbFees.Text);
             TotalFees.Text = LocalFees.ToString();
            }


        }
        private void AddNewTestAppointment()
        {
            int CountOfAppointmentID=DVLD.CountOfTestRepeat(LocalDrivingApplicationID,TestTypeID);
            int UserID = User.GetUserIDByUserNameAndPassword(UserInfo.UserName, UserInfo.Password);
            
            decimal fees =Convert.ToDecimal(LbFees.Text);
            if (CountOfAppointmentID == 0)
            {
                TestAppointment.AddNewAppointment(TestTypeID, LocalDrivingApplicationID, DateTime.Now, fees, UserID, 0, 0);
            }
            else
            {
                int PersonID = LocalDrivingApplication.GetPersonIDByLocalDrivingApplicationID(LocalDrivingApplicationID);
                MessageBox.Show(PersonID.ToString());
                int ApplicationRetakeID = Application14.AddNewRetakeApplication(PersonID, DateTime.Now, 7,3, DateTime.Now,Application14.GetFeesApplicationByApplicationTypeID(7) , User.GetUserIDByUserNameAndPassword(UserInfo.UserName, UserInfo.Password));
                MessageBox.Show(ApplicationRetakeID.ToString());
               
                TestAppointment.AddNewAppointment(TestTypeID, LocalDrivingApplicationID, DateTime.Now, fees, UserID, 0, ApplicationRetakeID);

            }
         



        }

        private void SaveTheTestAppointment() {
            if (AppointmentID == -1)
            {

            }
            else
            {
                if(TestAppointment.IsTestTypeActive(0, TestTypeID, ClassName,LocalDrivingApplicationID) )
                    {
                    MessageBox.Show(" لا يمكنك اضافة لانك لديك طلب فعال");
                    

                }
                 else
                {

                    AddNewTestAppointment();
                    MessageBox.Show("  العملية تمت بنجاح");

                }


            }
        
        
        
        
        
        
        }


        private void StoreTheData()
        {

            if (TestTypeID == 1)
            {
               
                LbFees.Text = Test.GetFeesTypeByTestTypeID(1).ToString()    ;
                LbTrial.Text = DVLD.CountOfTestRepeat(LocalDrivingApplicationID, 1).ToString();
               
            }
            if (TestTypeID == 2) { 
            pictureBox1.BackgroundImage=PictureWritten.BackgroundImage;
                groupBox1.Text = "Written Test";
                LbFees.Text = Test.GetFeesTypeByTestTypeID(2).ToString();
                LbTrial.Text = DVLD.CountOfTestRepeat(LocalDrivingApplicationID, 2).ToString();
              


            }
            if (TestTypeID == 3) {
                groupBox1.Text = "Driving Test";
                pictureBox1.BackgroundImage=PictureDriving.BackgroundImage;
                LbFees.Text = Test.GetFeesTypeByTestTypeID(3).ToString();
                LbTrial.Text = DVLD.CountOfTestRepeat(LocalDrivingApplicationID, 3).ToString();
             
            }


        }

        private void ScheduleTest_Load(object sender, EventArgs e)
        {
            StoreTheData();
            StoreTheDataInControls();
        }

        private void BtSave_Click(object sender, EventArgs e)
        {


            SaveTheTestAppointment();
        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LbFees_Click(object sender, EventArgs e)
        {

        }
    }
}








