using PeopleBusinessLayer1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserBusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace مشروع_كورس_19
{
    public partial class PeopleManage : Form
    {


        DataTable DataTable1;
        private void FilterAndDisplayPeople()
        {

            if (CbFilter.Text == "Last Name")
            {
                DataTable1= People.GetPersonByLastName(TbFilter.Text);
                if(DataTable1.Columns .Count>3 )
                {
                    dataGridView1.DataSource = DataTable1;
                }
                else
                {
                    dataGridView1.DataSource = People.GetAllInfoPeople();
                }
              

            }

            if (CbFilter.Text == "First Name")
            {
                DataTable1 = People.GetPersonByFistName(TbFilter.Text);
                if (DataTable1.Columns.Count > 3)
                {
                    dataGridView1.DataSource = DataTable1;
                }
                else
                {
                    dataGridView1.DataSource = People.GetAllInfoPeople();
                }


            }


            if (CbFilter.Text == "ThirdName")
            {
                DataTable1 = People.GetPersonByThirdName(TbFilter.Text);
                if (DataTable1.Columns.Count > 3)
                {
                    dataGridView1.DataSource = DataTable1;
                }
                else
                {
                    dataGridView1.DataSource = People.GetAllInfoPeople();
                }


            }

            if (CbFilter.Text == "Nationalty")
            {
                DataTable1 = People.GetPersonByCountryName(TbFilter.Text);
                if (DataTable1.Columns.Count > 3)
                {
                    dataGridView1.DataSource = DataTable1;
                }
                else
                {
                    dataGridView1.DataSource = People.GetAllInfoPeople();
                }


            }



            if (CbFilter.Text == "Gendor")
            {
                DataTable1 = People.GetPersonByGendor(TbFilter.Text);
                if (DataTable1.Columns.Count > 3)
                {
                    dataGridView1.DataSource = DataTable1;
                }
                else
                {
                    dataGridView1.DataSource = People.GetAllInfoPeople();
                }


            }

            if (CbFilter.Text == "Phone")
            {


                int f = 0;
                if ((int.TryParse(TbFilter.Text, out int number)))
                {


                    f = Convert.ToInt32(TbFilter.Text);

                }
                DataTable1 = People.GetPersonByPhone(f);
                if (DataTable1.Columns.Count > 3)
                {
                    dataGridView1.DataSource = DataTable1;
                }
                else
                {
                    dataGridView1.DataSource = People.GetAllInfoPeople();
                }


            }



            if (CbFilter.Text == "Email")
            {
                DataTable1 = People.GetPersonByEmail(TbFilter.Text);
                if (DataTable1.Columns.Count > 3)
                {
                    dataGridView1.DataSource = DataTable1;
                }
                else
                {
                    dataGridView1.DataSource = People.GetAllInfoPeople();
                }


            }


            if (CbFilter.Text == "Second Name")
            {
                DataTable1 = People.GetPersonBySecondName(TbFilter.Text);
                if (DataTable1.Columns.Count > 3)
                {
                    dataGridView1.DataSource = DataTable1;
                }
                else
                {
                    dataGridView1.DataSource = People.GetAllInfoPeople();
                }


            }

            if (CbFilter.Text == "National No")
            {
                DataTable1 = People.GetPersonByNationalNO(TbFilter.Text);
                if (DataTable1.Columns.Count > 3)
                {
                    dataGridView1.DataSource = DataTable1;
                }
                else
                {
                    dataGridView1.DataSource = People.GetAllInfoPeople();
                }


            }

            if (CbFilter.Text == "Person ID")
            {
                int f = 0;
                if ((int.TryParse(TbFilter.Text, out int number))){


                    f = Convert.ToInt32(TbFilter.Text);

                }
                    DataTable1 = People.GetPersonByPersonID(f);
                
                                if (DataTable1.Columns.Count > 3)
                {
                    dataGridView1.DataSource = DataTable1;
                }
                else
                {
                    dataGridView1.DataSource = People.GetAllInfoPeople();
                }


            }
            //Nationalty


        }



        private void LoadAllPeopleData()
        {
           dataGridView1.DataSource = People.GetAllInfoPeople();

   
         // dataGridView1.DataSource = People.GetPersonByCountryName("Jdan");

            




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



        private void ToggleFilterTextBoxEnabledState()
        {
            if (CbFilter.Text != "None")
            {
                TbFilter.Enabled = true;
            }
            else
            {
                TbFilter.Enabled = false;
            }

        }

        private void ValidateFilterSelectionAndAdjustTextBox()
        {
            
            if (CbFilter.Text == "First Name")
            {

                SetFilterTextBoxForStringInput();



            }
            if (CbFilter.Text == "Last Name")
            {
                SetFilterTextBoxForStringInput();


            }
           
            if (CbFilter.Text == "ThirdName")
            {
                SetFilterTextBoxForStringInput();



            }
            if (CbFilter.Text == "Nationalty")
            {
                SetFilterTextBoxForStringInput();

            }
            if (CbFilter.Text == "Gendor")

            {
                SetFilterTextBoxForStringInput();


            }
            if (CbFilter.Text == "Phone")
            {
                SetFilterTextBoxForNumericInput();


            }
           if(CbFilter.Text== "Email")
            {

                SetFilterTextBoxForStringInput();

            }

            if (CbFilter.Text == "Person ID")
            {

                SetFilterTextBoxForNumericInput();
            }
            if (CbFilter.Text == "National No")
            {
                SetFilterTextBoxForStringInput();

            }

            if (CbFilter.Text == "Second Name")
            {
                SetFilterTextBoxForStringInput();

            }
            if (CbFilter.Text == "None")
            {
                TbFilter.ReadOnly = true;

            }



        }


       

        public PeopleManage()
        {
            InitializeComponent();
        }

        private void PeopleManage_Load(object sender, EventArgs e)
        {
            LoadAllPeopleData();
            CbFilter.SelectedIndex = 0;
           
            
        }

     

        private void CbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            ToggleFilterTextBoxEnabledState();

        }

        private void TbFilter_TextChanged(object sender, EventArgs e)
        {

            ValidateFilterSelectionAndAdjustTextBox();
            FilterAndDisplayPeople();

        }

        private void PbAddNewPerson_Click(object sender, EventArgs e)
        {

            EditAndAddInfoPerson frm = new EditAndAddInfoPerson(-1);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(); // أو Show() حسب ما تريد
            LoadAllPeopleData();


        }

      

        private void ShowPersonDetails_Click_1(object sender, EventArgs e)
        {

            PersonINFO_cs frm = new PersonINFO_cs((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            LoadAllPeopleData();

        }

        private void UpdatePerson_Click(object sender, EventArgs e)
        {


            EditAndAddInfoPerson frm = new EditAndAddInfoPerson((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(); // أو Show() حسب ما تريد
            LoadAllPeopleData();

        }

        private void DeletePerson_Click(object sender, EventArgs e)
        {

            if (User.FindThePersonID((int)dataGridView1.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show(" لا يمكن حذف هذا الشخص ");

            }
            else
            {
                DialogResult result = MessageBox.Show("هل أنت متأكد أنك تريد الحذف؟"+ "PersonID= "+ (int)dataGridView1.CurrentRow.Cells[0].Value, "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {
                    People.DeletePerson((int)dataGridView1.CurrentRow.Cells[0].Value);
                    // هنا تضع كود الحذف
                    MessageBox.Show("تم الحذف بنجاح.");
                }
                else
                {
                    // هنا كود في حال اختار المستخدم No (اختياري)
                    MessageBox.Show("تم إلغاء العملية.");
                }

            }
            LoadAllPeopleData();


        }

        private void addPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditAndAddInfoPerson frm = new EditAndAddInfoPerson(-1);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(); // أو Show() حسب ما تريد
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
