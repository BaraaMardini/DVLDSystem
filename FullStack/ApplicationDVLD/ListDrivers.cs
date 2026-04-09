using DriverBusinessLayer;
using LicensesBusinessLayer;
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
    public partial class ListDrivers : Form
    {
        public ListDrivers()
        {
            InitializeComponent();
        }





        private void FilterLicenseByDriverID()
        {
            LoadAllLicensesData();
            DataTable EmployeesDataTable = Driver.GetAllDataDriver();
            int ResultCount = 0;
            DataRow[] ResultRows;


            for (int i = 0; i < EmployeesDataTable.Rows.Count; i++)
            {

                //   if3   0  
                if (EmployeesDataTable.Rows[i][0].ToString() == TbFilter.Text.ToString())
                {
                    string c = EmployeesDataTable.Rows[i][0].ToString();
                 
                    ResultRows = EmployeesDataTable.Select("[DriverID] = " + EmployeesDataTable.Rows[i][0]);
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



        private void FilterLicenseByNationalNO()
        {
            LoadAllLicensesData();

            DataTable EmployeesDataTable = Driver.GetAllDataDriver();
            int ResultCount = 0;
            DataRow[] ResultRows;


            for (int i = 0; i < EmployeesDataTable.Rows.Count; i++)
            {

                //   if3   0  
                if (EmployeesDataTable.Rows[i][2].ToString() == TbFilter.Text.ToString())
                {
                    string c = EmployeesDataTable.Rows[i][2].ToString();

                    ResultRows = EmployeesDataTable.Select("[NationalNo] = '" + c + "'");
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




        private void FilterLicenseByFullName()
        {
            LoadAllLicensesData();

            DataTable EmployeesDataTable = Driver.GetAllDataDriver();
            int ResultCount = 0;
            DataRow[] ResultRows;


            for (int i = 0; i < EmployeesDataTable.Rows.Count; i++)
            {

                //   if3   0  
                if (EmployeesDataTable.Rows[i][3].ToString() == TbFilter.Text.ToString())
                {
                    string c = EmployeesDataTable.Rows[i][3].ToString();

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
        private void FilterLicenseByPersonID()
        {
            LoadAllLicensesData();
            DataTable EmployeesDataTable = Driver.GetAllDataDriver();
            int ResultCount = 0;
            DataRow[] ResultRows;


            for (int i = 0; i < EmployeesDataTable.Rows.Count; i++)
            {

                //   if3   0  
                if (EmployeesDataTable.Rows[i][1].ToString() == TbFilter.Text.ToString())
                {
                    string c = EmployeesDataTable.Rows[i][1].ToString();
                  
                    ResultRows = EmployeesDataTable.Select("[PersonID] = " + EmployeesDataTable.Rows[i][1]);
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


        private void LoadAllLicensesData()
        {
            dataGridView1.DataSource = Driver.GetAllDataDriver();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

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


         private void HandleTextFilterSelection()
        {
            if (CbFilter.Text == "Person ID")
            {
              
                SetFilterTextBoxForNumericInput();
                FilterLicenseByPersonID();
            }
            if (CbFilter.Text == "National No")
            {
                SetFilterTextBoxForStringInput();
                FilterLicenseByNationalNO();
            }
            if (CbFilter.Text == "Full Name")
            {
                SetFilterTextBoxForStringInput();
                FilterLicenseByFullName();

            }

                if (CbFilter.Text == "Driver ID")
            {
                SetFilterTextBoxForNumericInput();
                FilterLicenseByDriverID();

            }



        }

        private void UpdateFilterInputVisibility()
        {
            if (CbFilter.Text == "Driver ID")
            {
                TbFilter.Enabled = true;

            }
            if (CbFilter.Text == "Person ID")
            {
                TbFilter.Enabled = true;


            }
            if (CbFilter.Text == "National No")
            {
                TbFilter.Enabled= true;

            }
            if (CbFilter.Text == "Full Name")
            {
                TbFilter.Enabled =true;



            }

        
            if (CbFilter.Text == "None")
            {
                TbFilter.Enabled = false;
            }
        }
        private void ListDrivers_Load(object sender, EventArgs e)
        {
            LoadAllLicensesData();
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
    }
}
