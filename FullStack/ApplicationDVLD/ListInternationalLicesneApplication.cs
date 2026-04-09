using InternationalLicensesBusinessLayer;
using LicensesBusinessLayer;
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
using UserBusinessLayer;

namespace مشروع_كورس_19
{
    public partial class ListInternationalLicesneApplication : Form
    {
        public ListInternationalLicesneApplication()
        {
            InitializeComponent();
        }

        private void FilterInternationalLicenseByIntLicenseID()
        {
            LoadAllInternationalLicensesData();
            DataTable EmployeesDataTable = InternationalLicenses.GetAllInternationalLicenses();
            int ResultCount = 0;
            DataRow[] ResultRows;


            for (int i = 0; i < EmployeesDataTable.Rows.Count; i++)
            {

                //   if3   0  
                if (EmployeesDataTable.Rows[i][0].ToString() == TbFilter.Text.ToString())
                {

                    string c = EmployeesDataTable.Rows[i][0].ToString();

                    ResultRows = EmployeesDataTable.Select("[Int.License ID] = '" + c + "'");
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

        private void FilterInternationalLicenseByApplicationID()
        {
            LoadAllInternationalLicensesData();
            DataTable EmployeesDataTable = InternationalLicenses.GetAllInternationalLicenses();
            int ResultCount = 0;
            DataRow[] ResultRows;


            for (int i = 0; i < EmployeesDataTable.Rows.Count; i++)
            {

                //   if3   0  
                if (EmployeesDataTable.Rows[i][1].ToString() == TbFilter.Text.ToString())
                {

                    string c = EmployeesDataTable.Rows[i][1].ToString();

                    ResultRows = EmployeesDataTable.Select("[Application ID] = '" + c + "'");
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

        private void FilterInternationalLicenseByDriverID()
        {
            LoadAllInternationalLicensesData();
            DataTable EmployeesDataTable = InternationalLicenses.GetAllInternationalLicenses();
            int ResultCount = 0;
            DataRow[] ResultRows;


            for (int i = 0; i < EmployeesDataTable.Rows.Count; i++)
            {

                //   if3   0  
                if (EmployeesDataTable.Rows[i][2].ToString() == TbFilter.Text.ToString())
                {

                    string c = EmployeesDataTable.Rows[i][2].ToString();

                    ResultRows = EmployeesDataTable.Select("[Driver ID] = '" + c + "'");
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
        private void FilterInternationalLicenseByLicenseID()
        {
            LoadAllInternationalLicensesData();
            DataTable EmployeesDataTable = InternationalLicenses.GetAllInternationalLicenses();
            int ResultCount = 0;
            DataRow[] ResultRows;


            for (int i = 0; i < EmployeesDataTable.Rows.Count; i++)
            {

                //   if3   0  
                if (EmployeesDataTable.Rows[i][3].ToString() == TbFilter.Text.ToString())
                {

                    string c = EmployeesDataTable.Rows[i][3].ToString();

                    ResultRows = EmployeesDataTable.Select("[L.License ID] = '" + c + "'");
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
        private void FilterInternationalLicenseByIsActive()
        {
            LoadAllInternationalLicensesData();
            DataTable EmployeesDataTable = InternationalLicenses.GetAllInternationalLicenses();
            int ResultCount = 0;
            DataRow[] ResultRows;


            for (int i = 0; i < EmployeesDataTable.Rows.Count; i++)
            {

                //   if3   0  
                if (EmployeesDataTable.Rows[i][6].ToString() == TbFilter.Text.ToString())
                {

                    string c = EmployeesDataTable.Rows[i][6].ToString();

                    ResultRows = EmployeesDataTable.Select("[Is Active] = '" + c + "'");
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
        private bool HandleTextFilterSelection()
        {
            if (CbFilter.Text == "Int.License ID")
            {

                SetFilterTextBoxForNumericInput();
                FilterInternationalLicenseByIntLicenseID();
                
                return true;

            }
            if (CbFilter.Text == "Application ID")
            {

                SetFilterTextBoxForNumericInput();
                FilterInternationalLicenseByApplicationID();
                
                return true;

            }
            if (CbFilter.Text == "Driver ID")
            {

                SetFilterTextBoxForNumericInput();
                FilterInternationalLicenseByDriverID();
                return true;

            }
            if (CbFilter.Text == "L.License ID")
            {

                SetFilterTextBoxForNumericInput();
                FilterInternationalLicenseByLicenseID();
               
                return true;

            }
            if (CbFilter.Text == "Is Active")
            {
                SetFilterTextBoxForNumericInput();
                FilterInternationalLicenseByIsActive();
                return true;

            }
            if (CbFilter.Text == "None")
            {
                
                return true;

            }
            return true;


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
        private bool UpdateFilterInputVisibility()
        {
            if (CbFilter.Text == "Int.License ID")
            {
                TbFilter.Enabled = true;
                return true;

            }
            if (CbFilter.Text == "Application ID")
            {
                TbFilter.Enabled = true;
                return true;

            }
            if (CbFilter.Text == "Driver ID")
            {
                TbFilter.Enabled = true;
                return true;

            }
            if (CbFilter.Text == "L.License ID")
            {
                TbFilter.Enabled         = true;
                return true;

            }
            if (CbFilter.Text == "Is Active")
            {
                TbFilter.Enabled = true;
                return true;

            }
            if (CbFilter.Text == "None")
            {
                TbFilter.Enabled = false;
                return true;

            }
            return true;
        }

        private void LoadAllInternationalLicensesData()
        {
            dataGridView1.DataSource = InternationalLicenses.GetAllInternationalLicenses();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.False;


        }
        private void ListInternationalLicesneApplication_Load(object sender, EventArgs e)
        {
            LoadAllInternationalLicensesData();
            CbFilter.SelectedIndex = 0;
        }

        private void CbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFilterInputVisibility();
        }

        private void TbFilter_TextChanged(object sender, EventArgs e)
        {
            HandleTextFilterSelection();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            NewInternationalLicenseApplication frm = new NewInternationalLicenseApplication();

            // إعداد يدوي للموقع
            frm.StartPosition = FormStartPosition.Manual;

            // تعيين العرض الجديد (مثلاً 800 بدلاً من 400)
            frm.Width = 900;

            // جعل الارتفاع يغطي الشاشة بالكامل
            frm.Height = Screen.PrimaryScreen.Bounds.Height;

            // حساب X ليكون في منتصف الشاشة حسب العرض الجديد
            int x = (Screen.PrimaryScreen.Bounds.Width - frm.Width) / 2;
            int y = 0;

            // تعيين الموقع
            frm.Location = new Point(x, y);

            // (اختياري) إزالة الحدود
            // frm.FormBorderStyle = FormBorderStyle.None;

            // عرض الفورم
            frm.ShowDialog();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //(int)dataGridView1.CurrentRow.Cells[1].Value
            PersonINFO_cs frm = new PersonINFO_cs(People.GetPersonIDByLicenseID((int)dataGridView1.CurrentRow.Cells[3].Value));
            frm.StartPosition = FormStartPosition.CenterParent;
 
            frm.ShowDialog();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {



            InternationalDriverInfo frm = new InternationalDriverInfo((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.StartPosition = FormStartPosition.CenterParent;

            frm.ShowDialog();
        }

        private void showPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {




            // إعداد يدوي للموقع
            LicenseHistory frm = new LicenseHistory(0, (int)dataGridView1.CurrentRow.Cells[3].Value);
            frm.StartPosition = FormStartPosition.CenterParent;
        
            frm.ShowDialog();
        }
    }
}
