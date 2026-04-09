using PeopleBusinessLayer1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace مشروع_كورس_19
{
    public partial class EditAndAddInfoPerson : Form
    {
        





         int ID = 0;


        private bool UpdatePersonInfo()
        {
            if (ValidatePersonInputs() == false)
            {
                MessageBox.Show("العملية تمت بفشل ");
                return false;

            }

            int Gendor = 0;
            if (RbMale.Checked == true)
            {
                Gendor = 1;
            }
            if (RbFemale.Checked == true)
            {
                Gendor = 0;
            }



            


           People.UpdatePersonInfo  (ID,TbFirstName.Text, TbSecondName.Text, TbThirdName.Text, TbLastName.Text, dateTimePicker1.Value, CbCountries.SelectedIndex + 1, TbNationalNo.Text, TbAddress.Text, TbEmail.Text, TbPhone.Text, "", Gendor);

             MessageBox.Show("العملية تمت بنجاح ");
             return true;
            

        
          

        }
        
          private void LoadPersonDetailsIntoForm()
        {



            DataTable table = People.GetPersonByPersonID1(ID);
            



            DataRow row = table.Rows[0];
            LbPersonID.Text = row[0].ToString();
            TbNationalNo.Text = row[1].ToString();
            TbFirstName.Text = row[2].ToString();
            TbSecondName.Text = row[3].ToString();
            TbThirdName.Text = row[4].ToString();
            TbLastName.Text = row[5].ToString();
            if (row[6].ToString() == "Male")
            {
                RbMale.Checked = true;
            }
            else
            {
                RbFemale.Checked = true;
            }

            dateTimePicker1.Text = row[7].ToString();
            CbCountries.Text = row[8].ToString();
            TbPhone.Text = row[9].ToString();
            TbEmail.Text = row[10].ToString();
            TbAddress.Text = row[11].ToString();

        }
        private void TryUpdatePerson()
        {
            if (ID != -1)
            {


                UpdatePersonInfo();

            }
            




        }

        private bool AddNewPerson()
        {
            if(ValidatePersonInputs ()== false)
            {
                MessageBox.Show("العملية تمت بفشل ");
                return false;
             

            }



            int Gendor = 0;
            if (RbMale.Checked == true)
            {
                Gendor = 0;
            }
            if (RbFemale.Checked == true) {
                Gendor = 1;
            }

            
            
            


                LbPersonID.Text = People.AddNewPerson(TbFirstName.Text, TbSecondName.Text, TbThirdName.Text, TbLastName.Text, dateTimePicker1.Value, CbCountries.SelectedIndex+1, TbNationalNo.Text, TbAddress.Text, TbEmail.Text, TbPhone.Text, "", Gendor).ToString();

                MessageBox.Show("العملية تمت بنجاح ");
                return true;
            
        }
        private bool ValidatePersonInputs()
        {
           // TbEmail.Text.Count() > 0
            if (TbFirstName.Text.Count() ==0)
            {

                MessageBox.Show("Your First Name Is Null");
                return false;
            }
            if(TbSecondName.Text.Count() ==0) {

                MessageBox.Show("Your Second Name Is Null");
                return false;
            
            }


            if (TbLastName.Text.Count() ==0) {

                MessageBox.Show("Your Last Name Is Null");
                return false; 
            }


            if(TbNationalNo.Text.Count() == 0) {

                MessageBox.Show("Your NationalNo Is Null");
                return false; 
            
            } 

            if(CbCountries.Text.Count() ==0) {

                MessageBox.Show("Your Country Is Null");
                return false;
            }


            if(TbPhone.Text.Count() ==0) 
            {

                MessageBox.Show("Your Phone Is Null");
                return false;
            }


            if(RbFemale.Checked!=true &&  RbMale.Checked != true) {

                MessageBox.Show("Your Gender  Is Null");
                return false;
            }


           



            return true ;

        }
      
        public EditAndAddInfoPerson(int ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

      




        private void EditAndAddInfoPerson_Load(object sender, EventArgs e)
        {
            if (ID != -1)
            {
                label1.Text = "Update Perosn";
                LoadPersonDetailsIntoForm();


            }
          CbCountries.DataSource = People.GetAllCountries();
           CbCountries.DisplayMember = "CountryName";
        



        }

       


        private void TbNationalNo_Validating(object sender, CancelEventArgs e)
        {

          DataTable DataTable1=  People.GetPersonByNationalNO(TbNationalNo.Text);
            if (DataTable1.Columns.Count > 0) {
                errorProvider1.SetError(TbNationalNo,"يجب تغير الرقم الوطني لانه موجود في السستم");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(TbNationalNo, ""); // إزالة الخطأ إذا الشرط تحقق
            }




        }

        private void RbFemale_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = PictureGirl.BackgroundImage;


        }

        private void RbMale_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage=PictureBoy.BackgroundImage;
        }

       

        private void TbEmail_Validating(object sender, CancelEventArgs e)
        {


            if (TbEmail.Text.Count()>0)
            {

                if ((TbEmail.Text.Contains(".com") && TbEmail.Text.Contains("@")))
                {

                    e.Cancel = false;

                }
                else
                {
                    e.Cancel = true;
                }

            }
             

            }

        private void BtSave_Click(object sender, EventArgs e)
        {

            if (ID != -1)
            {

                TryUpdatePerson();
            }
            else
            {
                AddNewPerson();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void CbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
