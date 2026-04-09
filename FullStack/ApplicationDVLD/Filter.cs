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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace مشروع_كورس_19
{
    public partial class Filter : UserControl
    {

        int PersonID;
        public Filter()
        {
            InitializeComponent();
            this.AutoScroll = true;
        }

        public int ID
        {
            get { return personDetails1.PersonID2; }
        }


        public void ReceiveMessage(int ID)
        {

            this.PersonID = ID;
      
            personDetails1.PersonID = ID;
            TbFilter.Enabled = false;
            CbFilter.Enabled = false;
            PbFindThePerson.Enabled = false;
            PbAddNewPerson.Enabled = false; 

        }
        public void PersonIDForLicense(int PersonID)
        {


            personDetails1.PersonIDForLicense(PersonID);
            TbFilter.Text = PersonID.ToString();
            CbFilter.Enabled=false;
            TbFilter.Enabled=false;
            PbFindThePerson.Enabled=false;
            PbAddNewPerson.Enabled=false;
            

        }

        private void CheakOfFindPerosn()
        {
            if (CbFilter.Text == "PersonID")
            {
                DataTable DataTable1 = People.GetPersonByPersonID( Convert.ToInt32(TbFilter.Text));
                if (DataTable1.Columns.Count > 0)
                {
                    GetTheInfo();
                }
                else
                {

                    MessageBox.Show("لا يوجد هذا الرقم");


                }
            }

            if (CbFilter.Text == "National No.")
            {

                DataTable DataTable1 = People.GetPersonByNationalNO(TbFilter.Text);
                if (DataTable1.Columns.Count > 0)
                {
                    GetTheInfo();
                }
                else
                {

                    MessageBox.Show("لا يوجد هذا الرقم");


                }






            }
        }

        private void SetFilterTextBoxForStringInput()
        {
            if (int.TryParse(TbFilter.Text, out int number))
            {

                TbFilter.ReadOnly = true;
                TbFilter.Clear();



            }
            else
            {

                TbFilter.ReadOnly = false;

            }


        }
        private void SetFilterTextBoxForNumericInput()
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



        }



        private void GetTheInfo()
        {

            if (CbFilter.Text == "PersonID")
            {
                SetFilterTextBoxForNumericInput();

               

                    personDetails1.PersonID = Convert.ToInt32(TbFilter.Text);
                

            }
            if(CbFilter.Text == "National No.")
            {

                SetFilterTextBoxForStringInput();
                personDetails1.NationalNO=TbFilter.Text;


            }


        }
        
        private void Filter_Load(object sender, EventArgs e)
        {
           
            CbFilter.SelectedIndex = 0;
           


        }

        private void PbAddNewPerson_Click(object sender, EventArgs e)
        {

            EditAndAddInfoPerson frm = new EditAndAddInfoPerson(-1);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(); // أو Show() حسب ما تريد
        }

        private void PbFindThePerson_Click(object sender, EventArgs e)
        {


            CheakOfFindPerosn();


            
        }

        private void personDetails1_Load(object sender, EventArgs e)
        {

        }

        private void TbFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void personDetails1_Load_1(object sender, EventArgs e)
        {

        }
    }
}




           
