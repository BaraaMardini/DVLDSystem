using DetainedLicensesBusinessLayer;
using InternationalLicensesBusinessLayer;
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

namespace مشروع_كورس_19
{
    public partial class ListDetainedLicenses : Form
    {
        public ListDetainedLicenses()
        {
            InitializeComponent();
        }


        private void RefreshContextMenuOptions()
        {
            if ((bool)dataGridView1.CurrentRow.Cells[3].Value == true)
            {
                
                releaseDetainedToolStripMenuItem.Enabled = false;
            }

            else
            {
                releaseDetainedToolStripMenuItem.Enabled= true;
            }
        }
        private void FilterDetainedLicenseByDetainedID()
        {
            LoadAllDetainedLicensesData();
            DataTable EmployeesDataTable = DetainedLicenses.GetAllDetainedLicenses();
            int ResultCount = 0;
            DataRow[] ResultRows;


            for (int i = 0; i < EmployeesDataTable.Rows.Count; i++)
            {

                //   if3   0  
                if (EmployeesDataTable.Rows[i][0].ToString() == TbFilter.Text.ToString())
                {

                    string c = EmployeesDataTable.Rows[i][0].ToString();

                    ResultRows = EmployeesDataTable.Select("[Detain ID] = '" + c + "'");
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
        private void FilterDetainedLicenseByIsReleased()
        {
            LoadAllDetainedLicensesData();
            DataTable EmployeesDataTable = DetainedLicenses.GetAllDetainedLicenses();
            int ResultCount = 0;
            DataRow[] ResultRows;


            for (int i = 0; i < EmployeesDataTable.Rows.Count; i++)
            {

                //   if3   0  
                if (EmployeesDataTable.Rows[i][3].ToString() == TbFilter.Text.ToString())
                {

                    string c = EmployeesDataTable.Rows[i][3].ToString();

                    ResultRows = EmployeesDataTable.Select("[Is Released] = '" + c + "'");
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
        private void FilterDetainedLicenseByFullName()
        {
            LoadAllDetainedLicensesData();
            DataTable EmployeesDataTable = DetainedLicenses.GetAllDetainedLicenses();
            int ResultCount = 0;
            DataRow[] ResultRows;


            for (int i = 0; i < EmployeesDataTable.Rows.Count; i++)
            {

                //   if3   0  
                if (EmployeesDataTable.Rows[i][7].ToString() == TbFilter.Text.ToString())
                {

                    string c = EmployeesDataTable.Rows[i][7].ToString();

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

        private void FilterDetainedLicenseByNationalNO()
        {
            LoadAllDetainedLicensesData();
            DataTable EmployeesDataTable = DetainedLicenses.GetAllDetainedLicenses();
            int ResultCount = 0;
            DataRow[] ResultRows;


            for (int i = 0; i < EmployeesDataTable.Rows.Count; i++)
            {

                //   if3   0  
                if (EmployeesDataTable.Rows[i][6].ToString() == TbFilter.Text.ToString())
                {

                    string c = EmployeesDataTable.Rows[i][6].ToString();

                    ResultRows = EmployeesDataTable.Select("[National No] = '" + c + "'");
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


        private void FilterDetainedLicenseByReleaseApplicationID()
        {
            LoadAllDetainedLicensesData();
            DataTable EmployeesDataTable = DetainedLicenses.GetAllDetainedLicenses();
            int ResultCount = 0;
            DataRow[] ResultRows;


            for (int i = 0; i < EmployeesDataTable.Rows.Count; i++)
            {

                //   if3   0  
                if (EmployeesDataTable.Rows[i][8].ToString() == TbFilter.Text.ToString())
                {

                    string c = EmployeesDataTable.Rows[i][8].ToString();

                    ResultRows = EmployeesDataTable.Select("[Release Application ID] = '" + c + "'");
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
        //Release Application ID
        private bool HandleTextFilterSelection()
        {
            if (CbFilter.Text == "Detain ID")
            {
                SetFilterTextBoxForNumericInput();
          FilterDetainedLicenseByDetainedID();
                return true;

            }
            if (CbFilter.Text == "Is Released")
            {
                SetFilterTextBoxForNumericInput();
                FilterDetainedLicenseByIsReleased();
            
                return true;

            }
            if (CbFilter.Text == "Full Name")
            {
                SetFilterTextBoxForStringInput();
                FilterDetainedLicenseByFullName();

         
                return true;

            }
            if (CbFilter.Text == "National No")
            {
                SetFilterTextBoxForStringInput();
                FilterDetainedLicenseByNationalNO();
               
                return true;

            }
            if (CbFilter.Text == "Release Application ID")
            {
                SetFilterTextBoxForNumericInput();
                FilterDetainedLicenseByReleaseApplicationID();

              
                return true;

            }
            if (CbFilter.Text == "None")
            {
                TbFilter.Enabled = false;
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
            if (CbFilter.Text == "Detain ID")
            {
                TbFilter.Enabled = true;
                return true;

            }
            if (CbFilter.Text == "Is Released")
            {
                TbFilter.Enabled = true;
                return true;

            }
            if (CbFilter.Text == "Full Name")
            {
                TbFilter.Enabled = true;
                return true;

            }
            if (CbFilter.Text == "National No")
            {
                TbFilter.Enabled = true;
                return true;

            }
            if (CbFilter.Text == "Release Application ID")
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


        private void LoadAllDetainedLicensesData()
        {
            dataGridView1.DataSource = DetainedLicenses.GetAllDetainedLicenses();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.False;


        }




        private void ListDetainedLicenses_Load(object sender, EventArgs e)
        {
            LoadAllDetainedLicensesData();
        }

        private void TbFilter_TextChanged(object sender, EventArgs e)
        {
            HandleTextFilterSelection();
        }

        private void CbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFilterInputVisibility();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {


           DetainLicense frm = new DetainLicense();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Size = new Size(890, 790); // تعديل الطول فقط
            frm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicense frm = new ReleaseDetainedLicense(0);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Size = new Size(890, 790); // تعديل الطول فقط
            frm.ShowDialog();
        }

        private void showPerosnDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //(int)dataGridView1.CurrentRow.Cells[0].Value
            PersonINFO_cs frm = new PersonINFO_cs(People.GetPersonIDByLicenseID((int)dataGridView1.CurrentRow.Cells[1].Value));
            frm.StartPosition = FormStartPosition.CenterParent;
        //    frm.Size = new Size(890, 790); // تعديل الطول فقط
            frm.ShowDialog();


        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            LicenseInfo frm = new LicenseInfo(0, (int)dataGridView1.CurrentRow.Cells[1].Value);
            frm.StartPosition = FormStartPosition.CenterParent;
            //    frm.Size = new Size(890, 790); // تعديل الطول فقط
            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LicenseHistory frm = new LicenseHistory(0, (int)dataGridView1.CurrentRow.Cells[1].Value);
            frm.StartPosition = FormStartPosition.CenterParent;
            //    frm.Size = new Size(890, 790); // تعديل الطول فقط
            frm.ShowDialog();

        }

        private void releaseDetainedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicense frm = new ReleaseDetainedLicense((int)dataGridView1.CurrentRow.Cells[1].Value);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Size = new Size(890, 790); // تعديل الطول فقط
            frm.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            RefreshContextMenuOptions();
        }
    }
    }
