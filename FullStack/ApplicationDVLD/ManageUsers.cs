using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserBusinessLayer;
using ApplicationBusinessLayer14;
using TestBusinessLayer;
using DriverBusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace مشروع_كورس_19
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();

        }

        private bool CheakIfYouCanDelete()
        {

            if (Application14.FindTheApplicationByUserID((int)dataGridView1.CurrentRow.Cells[0].Value))
            {
                return false;
            }



            if (Test.FindTheTestByUserID((int)dataGridView1.CurrentRow.Cells[0].Value))
            {
                return false;
            }




            if (Driver.FindTheDriverByUserID((int)dataGridView1.CurrentRow.Cells[0].Value))
            {
                return false;
            }



            return true;
        }
        private void HandleActiveFilterSelection()
        {
            if (CbFilterIsActive.Text == "All")
            {
                FilterUsersByActiveStatus();
            }
            if (CbFilterIsActive.Text == "Yes")
            {
                FilterUsersByActiveTrue();
            }
            if (CbFilterIsActive.Text == "No")
            {
                FilterUsersByActiveFalse();
            }
        }
        private void FilterUsersByActiveStatus()
        {
            LoadAllUsersData();
            DataTable EmployeesDataTable = User.GetAllUsersData();
            int ResultCount = 0;
            DataRow[] ResultRows;


            //"Country='Jordan' or Country='Egypt'"



            ResultRows = EmployeesDataTable.Select("IsActive=0 or IsActive=1");
            if (ResultRows.Length > 0)
            {
                dataGridView1.DataSource = ResultRows.CopyToDataTable();
            }
            else
            {
                dataGridView1.DataSource = null; // أو DataTable فاضية
            }



        }




        private void FilterUsersByActiveFalse()
        {
            LoadAllUsersData();
            DataTable EmployeesDataTable = User.GetAllUsersData();
            int ResultCount = 0;
            DataRow[] ResultRows;






            ResultRows = EmployeesDataTable.Select("IsActive=0");
            if (ResultRows.Length > 0)
            {
                dataGridView1.DataSource = ResultRows.CopyToDataTable();
            }
            else
            {
                dataGridView1.DataSource = null; // أو DataTable فاضية
            }



        }




        private void FilterUsersByActiveTrue()
        {
            LoadAllUsersData();
            DataTable EmployeesDataTable = User.GetAllUsersData();
            int ResultCount = 0;
            DataRow[] ResultRows;






            ResultRows = EmployeesDataTable.Select("[IsActive] =true");
            if (ResultRows.Length > 0)
            {
                dataGridView1.DataSource = ResultRows.CopyToDataTable();
            }
            else
            {
                dataGridView1.DataSource = null; // أو DataTable فاضية
            }



        }




        private void FilterUsersByPersonId()
        {
            LoadAllUsersData();
            DataTable EmployeesDataTable = User.GetAllUsersData();
            int ResultCount = 0;
            DataRow[] ResultRows;


            for (int i = 0; i < EmployeesDataTable.Rows.Count; i++)
            {

                //   if3   0  
                if (EmployeesDataTable.Rows[i][1].ToString() == TbFilter.Text.ToString())
                {
                    string c = EmployeesDataTable.Rows[i][1].ToString();

                    ResultRows = EmployeesDataTable.Select("[Person ID] = '" + c + "'");
                    if (ResultRows.Length > 0)
                    {
                        dataGridView1.DataSource = ResultRows.CopyToDataTable();
                    }
                    else
                    {
                        dataGridView1.DataSource = null; // أو DataTable فاضية
                    }



                }



            }

        }
        private void FilterUsersByUserId()
        {
            LoadAllUsersData();
            DataTable EmployeesDataTable = User.GetAllUsersData();
            int ResultCount = 0;
            DataRow[] ResultRows;


            for (int i = 0; i < EmployeesDataTable.Rows.Count; i++)
            {

                //   if3   0  
                if (EmployeesDataTable.Rows[i][0].ToString() == TbFilter.Text.ToString())
                {
                    string c = EmployeesDataTable.Rows[i][0].ToString();

                    ResultRows = EmployeesDataTable.Select("[User ID] = '" + c + "'");
                    if (ResultRows.Length > 0)
                    {
                        dataGridView1.DataSource = ResultRows.CopyToDataTable();
                    }
                    else
                    {
                        dataGridView1.DataSource = null; // أو DataTable فاضية
                    }



                }



            }

        }
        private void FilterUsersByFullName()
        {
            LoadAllUsersData();

            DataTable EmployeesDataTable = User.GetAllUsersData();
            int ResultCount = 0;
            DataRow[] ResultRows;


            for (int i = 0; i < EmployeesDataTable.Rows.Count; i++)
            {

                //   if3   0  
                if (EmployeesDataTable.Rows[i][2].ToString() == TbFilter.Text.ToString())
                {
                    string c = EmployeesDataTable.Rows[i][2].ToString();

                    ResultRows = EmployeesDataTable.Select("[Full Name] = '" + c + "'");
                    if (ResultRows.Length > 0)
                    {
                        dataGridView1.DataSource = ResultRows.CopyToDataTable();
                    }
                    else
                    {
                        dataGridView1.DataSource = null; // أو DataTable فاضية
                    }



                }



            }


        }
        private void FilterUsersByUserName()
        {
            LoadAllUsersData();

            DataTable EmployeesDataTable = User.GetAllUsersData();
            int ResultCount = 0;
            DataRow[] ResultRows;


            for (int i = 0; i < EmployeesDataTable.Rows.Count; i++)
            {

                //   if3   0  
                if (EmployeesDataTable.Rows[i][3].ToString() == TbFilter.Text.ToString())
                {
                    string c = EmployeesDataTable.Rows[i][3].ToString();

                    ResultRows = EmployeesDataTable.Select("[User Name ] = '" + c + "'");
                    if (ResultRows.Length > 0)
                    {
                        dataGridView1.DataSource = ResultRows.CopyToDataTable();
                    }
                    else
                    {
                        dataGridView1.DataSource = null; // أو DataTable فاضية
                    }



                }



            }

        }
        private void HandleTextFilterSelection()
        {
            if (CbFilter.Text == "Person ID")
            {

                SetFilterTextBoxForNumericInput();
                FilterUsersByPersonId();

            }
            if (CbFilter.Text == "User ID")
            {

                SetFilterTextBoxForNumericInput();
                FilterUsersByUserId();

            }
            if (CbFilter.Text == "UserName")
            {


                SetFilterTextBoxForStringInput();
                FilterUsersByUserName();
            }
            if (CbFilter.Text == "Full Name")
            {

                SetFilterTextBoxForStringInput();
                FilterUsersByFullName();

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
        private void UpdateFilterInputVisibility()
        {
            if (CbFilter.Text == "Person ID")
            {
                TbFilter.Visible = true;

            }
            if (CbFilter.Text == "User ID")
            {
                TbFilter.Visible = true;


            }
            if (CbFilter.Text == "UserName")
            {
                TbFilter.Visible = true;

            }
            if (CbFilter.Text == "Full Name")
            {
                TbFilter.Visible = true;



            }

            if (CbFilter.Text == "Is Active")
            {

                TbFilter.Visible = false;

                CbFilterIsActive.Visible = true;




            }
            if (CbFilter.Text == "None") {
                TbFilter.Visible = false;
            }
        }



        private void LoadAllUsersData()
        {
            dataGridView1.DataSource = User.GetAllUsersData();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

        }
        private void ManageUsers_Load(object sender, EventArgs e)
        {
            LoadAllUsersData();

            CbFilter.SelectedIndex = 0;
            //     StoreTheDataInDataViewByNoActive();

        }



        private void CbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFilterInputVisibility();
        }

        private void TbFilter_TextChanged(object sender, EventArgs e)
        {

            HandleTextFilterSelection();


        }

        private void CbFilterIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            HandleActiveFilterSelection();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AddNewUser frm = new AddNewUser(-1);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Size = new Size(1280, 750); // تعديل الطول فقط
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadAllUsersData();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetailsUserAndPersonInfo frm = new DetailsUserAndPersonInfo((int)dataGridView1.CurrentRow.Cells[1].Value);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();




        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewUser frm = new AddNewUser(-1);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Size = new Size(1280, 750); // تعديل الطول فقط
            frm.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewUser frm = new AddNewUser((int)dataGridView1.CurrentRow.Cells[1].Value);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Size = new Size(1280, 750); // تعديل الطول فقط
            frm.ShowDialog();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chansePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ChangePassword frm = new ChangePassword((int)dataGridView1.CurrentRow.Cells[1].Value);

            // احصل على أبعاد الشاشة
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;

            // اضبط ارتفاع الفورم ليملأ الشاشة عموديًا
            frm.Height = screenHeight;

            // الموقع الأفقي: المنتصف
            int x = (screenWidth - frm.Width) / 2;

            // الموقع العمودي: أعلى الشاشة (Y = 0)
            int y = 0;

            // اضبط الموقع يدويًا
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(x, y);

            // اعرض الفورم
            frm.ShowDialog();




        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheakIfYouCanDelete())
            {

                User.DeleteUser((int)dataGridView1.CurrentRow.Cells[0].Value);
                MessageBox.Show(" العملية تمت بنجاح");
                LoadAllUsersData();
            }
            else
                MessageBox.Show(" لا يمكنك حذف هذا المسخدم");
            {
            }
        }




    }
}










