using PeopleBusinessLayer1;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace مشروع_كورس_19
{
    public partial class PersonDetails : UserControl
    {

        int ID;





        private int personID2;

        [Browsable(true)]
        [Category("Data")]
        public int PersonID2
        {
            get { return ID; }
            set
            {
                personID = value;
            
                  
            }
        }








        private string nationalNO;

        [Browsable(true)]
        [Category("Data")]
        public string NationalNO
        {
            get { return nationalNO; }
            set
            {
                nationalNO = value;
                if (!string.IsNullOrWhiteSpace(nationalNO))
                    GetThePersonByNationalNO();
            }



        }

        private int personID;

        [Browsable(true)]
        [Category("Data")]
        public int PersonID
        {
            get { return personID; }
            set
            {
                personID = value;
                if (personID > 0)
                    GetThePersonByPersonID();
            }
        }

        public PersonDetails()
        {
            InitializeComponent();
        }
         public void PersonIDForLicense(int PersonID)
        {
            this.PersonID = PersonID;
            GetThePersonByPersonID();



        }
        private void GetThePersonByPersonID()
        {
           
            DataTable table = People.GetPersonByPersonID1(personID);

           
            if (table != null && table.Rows.Count > 0)
            {

                DataRow row = table.Rows[0];
                ID = Convert.ToInt32(row[0]);

                LbPersonID.Text = row[0].ToString();
                LbNationalNO.Text = row[1].ToString();
                LbName.Text = $"{row[2]} {row[3]} {row[4]} {row[5]}";
                LbGendor.Text = row[6].ToString();
                LbBirthday.Text = row[7].ToString();
                LbCountry.Text = row[8].ToString();
                LbPhone.Text = row[9].ToString();
                LbEmail.Text = row[10].ToString();
                LbAddress.Text = row[11].ToString();
            }
            else
            {
              
              
            }
        }

        private void GetThePersonByNationalNO()
        {



            DataTable table = People.GetPersonBynNationNO1(NationalNO);


            if (table != null && table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                LbPersonID.Text = row[0].ToString();
                ID = Convert.ToInt32(row[0]);
                LbNationalNO.Text = row[1].ToString();
                LbName.Text = $"{row[2]} {row[3]} {row[4]} {row[5]}";
                LbGendor.Text = row[6].ToString();
                LbBirthday.Text = row[7].ToString();
                LbCountry.Text = row[8].ToString();
                LbPhone.Text = row[9].ToString();
                LbEmail.Text = row[10].ToString();
                LbAddress.Text = row[11].ToString();
            }
            else
            {


            }
        

    }
     

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ID!=0)
            {


                EditAndAddInfoPerson frm = new EditAndAddInfoPerson(ID);
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog(); // أو Show() حسب ما تريد
            }

       

          
          //  GetThePersonByPersonID();

        }

        private void PersonDetails_Load(object sender, EventArgs e)
        {
          
        }
    }
}