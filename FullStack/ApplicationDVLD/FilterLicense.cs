using DetainedLicensesBusinessLayer;
using InternationalLicensesBusinessLayer;
using LicensesBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace مشروع_كورس_19
{
    public partial class FilterLicense : UserControl 
        
    {

        public int NumberUntilChoeseBetweenScreen = 100;
      

        public delegate void DataBackEventHandler(object sender, int LicenseID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;



        public delegate void DataBackEventHandler2(object sender, int LicenseID);

        // Declare an event using the delegate
        public event DataBackEventHandler2 DataBack2;


        public delegate void DataBackEventHandler3(object sender, int LicenseID);

        // Declare an event using the delegate
        public event DataBackEventHandler2 DataBack3;


        public delegate void DataBackEventHandler4(object sender, int LicenseID);

        // Declare an event using the delegate
        public event DataBackEventHandler2 DataBack4;

        public delegate void DataBackEventHandler5(object sender, int LicenseID);

        // Declare an event using the delegate
        public event DataBackEventHandler2 DataBack5;

        public delegate void DataBackEventHandler6(object sender, int LicenseID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack6;

        public delegate void DataBackEventHandler7(object sender, int LicenseID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack7;

        public delegate void DataBackEventHandler8(object sender, int LicenseID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack8;


        public delegate void DataBackEventHandler9(object sender, int LicenseID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack9;




        public delegate void DataBackEventHandler10(object sender, int LicenseID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack10;
        public FilterLicense()
        {
            InitializeComponent();
        }
        private bool IsLicenseActive()
        {
            int LicenseID = Convert.ToInt32(TbFilter.Text);
            if (Licenses.CheakTheLicenseIDIsActive(LicenseID))
            {
                MessageBox.Show(" هذه الرخصة غير فعالة");
                return true;
            }
            return false;
        }
        private bool IsLicenseFound(int LicenseID)
        {
            if (Licenses.FindTheLicenseIDByLicenseID(LicenseID)) { 

                return true;
            }
           return false;
        }
        public bool IfFilterInScreenNewInternationalLicense()
        {




            int LicenseID = Convert.ToInt32(TbFilter.Text);

            if (IsLicenseFound(LicenseID))
            {

                if (!IsLicenseActive())
                {


                    if (InternationalLicenses.FindTheInternationalLicenseByLicenseID(LicenseID))
                    {
                        MessageBox.Show("هذا لديه رخصة دولية");
                        DataBack10?.Invoke(this, LicenseID);
                        return true;
                    }
                    if (Licenses.CheakLicenseIDIfLicenseClassIs3(LicenseID, 3))
                    {
                        
                        DataBack?.Invoke(this, LicenseID);
                        return true;
                    }




                }
            }
            return true;
            

        }
        public bool IfFilterInScreenRenewLocalDrivingLicense()
        {
    




            int LicenseID = Convert.ToInt32(TbFilter.Text);


            if (IsLicenseActive())
            {
              
  
                DataBack2?.Invoke(this, LicenseID);
                return true;


            }
                
            if(IsLicenseFound(LicenseID)) { 
                DateTime ExpirationDate = Licenses.GetExpirationDateByLicenseID(LicenseID);
                if (ExpirationDate < DateTime.Now)
                {
                    DataBack3.Invoke(this,LicenseID);

                }
                else
                {




                    MessageBox.Show(
               $"Selected License is not yet expired, it will expire on:\n{ExpirationDate}",
               "Not allowed",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                    DataBack2?.Invoke(this, LicenseID  );

                }

            }
            return true;
        }

        private bool IfFilterInReplacementForDamagedLicense()
        {
            int LicenseID = Convert.ToInt32(TbFilter.Text);
            if (IsLicenseActive()) {
                DataBack4.Invoke(this, LicenseID);
                return true;

            }
            if (IsLicenseFound(LicenseID))
            {

                if (Licenses.GetExpirationDateByLicenseID(LicenseID) < DateTime.Now)
                {
                    MessageBox.Show(
             $"Selected License is not yet expired, it will expire on:\n{Licenses.GetExpirationDateByLicenseID(LicenseID)}",
             "Not allowed",
             MessageBoxButtons.OK,
             MessageBoxIcon.Error);
                    DataBack4.Invoke(this, LicenseID);
                    return true;
                }


                else
                {
                    DataBack5.Invoke(this, LicenseID);


                }
            }
            
          

            return true;
        }

        private bool IfFilterInDetainedLicense()
        {
            int LicenseID = Convert.ToInt32(TbFilter.Text);
            if (IsLicenseFound(LicenseID))
            {
                if (IsLicenseActive())
                {
                    DataBack6.Invoke(this, LicenseID);
                    return true;


                }
                if (DetainedLicenses.CheakLicenseIDIsReleased(LicenseID, 0))
                {
                    MessageBox.Show(
    "Selected License is already detained, choose another one.",
    "Not allowed",
    MessageBoxButtons.OK,
    MessageBoxIcon.Error);
                    DataBack6.Invoke(this, LicenseID);
                    return true;
                }


                
                    DataBack7.Invoke(this, LicenseID);
                   
                   


                



            }



            return true;

        }

        private bool IfFilterInReleaseDetainLicense()
        {

            int LicenseID = Convert.ToInt32(TbFilter.Text);
            if (IsLicenseFound(LicenseID))
            {
                if (IsLicenseActive())
                {
                    DataBack8.Invoke(this, LicenseID);

                    return true;
                }

                if (!DetainedLicenses.CheakLicenseIDIsReleased(LicenseID, 0))
                {

                    MessageBox.Show(
    "Selected License is already  not detained, choose another one.",
    "Not allowed",
    MessageBoxButtons.OK,
    MessageBoxIcon.Error);
                    DataBack8.Invoke(this, LicenseID);

                    return true;
                }


                if (DetainedLicenses.CheakLicenseIDIsReleased(LicenseID, 0))
                {
                    DataBack9.Invoke(this, LicenseID);


                    return true;
                }



            }



            return true;

        }


        public void SendTheDataInControlDriveLicense()
        {

            int LicenseID = Convert.ToInt32(TbFilter.Text);
           driverLicenseInfo1.LicenseID = LicenseID;
            driverLicenseInfo1.StoreTheDataInControls1();
            if (NumberUntilChoeseBetweenScreen == 0)
            {
                IfFilterInScreenNewInternationalLicense();
            }

            if (NumberUntilChoeseBetweenScreen == 1)
            {

                IfFilterInScreenRenewLocalDrivingLicense();


            }

            if (NumberUntilChoeseBetweenScreen == 2)
            {

                IfFilterInReplacementForDamagedLicense();


            }
            if (NumberUntilChoeseBetweenScreen == 3)
            {
                IfFilterInDetainedLicense();
            }

            if (NumberUntilChoeseBetweenScreen == 4)
            {
                IfFilterInReleaseDetainLicense();
            }




        }
   




       

        
    
        public void EnabledFilter()
        {
            TbFilter.Enabled = false;
            pictureBox1.Enabled = false;

        }
        public int GetLicenseID() { 
        
        
        return Convert.ToInt32(TbFilter.Text);
        }


    public string IsActive()
        {
            return driverLicenseInfo1.IsActive();
        }

   

        private void TbFilter_TextChanged(object sender, EventArgs e)
        {
          
            if (!(int.TryParse(TbFilter.Text, out int number)))
            {

                TbFilter.ReadOnly = false;
                TbFilter.Clear();





            }
            else
            {
                TbFilter.ReadOnly = false;

            }
            if (TbFilter.Text.Length > 0)
            {
                SendTheDataInControlDriveLicense();

            }



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (TbFilter.Text.Length > 0) {
                SendTheDataInControlDriveLicense();

            }
           

        }

        private void FilterLicense_Load(object sender, EventArgs e)
        {

        }
        public  void StoreLicenseIDInTbFilter(int LicenseID)
        {
            TbFilter.Text = LicenseID.ToString();

        }
        private void driverLicenseInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
