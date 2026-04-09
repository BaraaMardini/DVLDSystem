using ConnectionName;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseClassesDataAccessLayer
{
    public class LicenseClassesData
    {


        static public int GetDefaultValidityLengthByLicenseID(int LicenseID)
        {


            int ValidityLength = 0;


            SqlConnection connection = new SqlConnection(Connection.ConnectionString);

            string query = "SELECT LicenseClasses.DefaultValidityLength\r\nFROM     Licenses INNER JOIN\r\n                  LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID\r\n\t\t\t\t  where Licenses.LicenseID=@LicenseID;";
            SqlCommand command = new SqlCommand(query, connection);
            {
                // إضافة المعاملات مع معالجة القيم الفارغة
                command.Parameters.AddWithValue("@LicenseID", LicenseID);


            }




            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int ValidityLength1))
                {
                    ValidityLength = ValidityLength1;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw; // (اختياري) يعيد رمي الخطأ إذا بدك توقف التنفيذ
            }
            finally
            {
                connection.Close();
            }

            return ValidityLength;


        }



        static public decimal GetTheClassFeesByLicenseClass(int LicenseClass)
        {

            decimal ClassFees = -1;
            string query = "SELECT  top (1 )LicenseClasses.ClassFees\r\nFROM     Licenses INNER JOIN\r\n                  LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID\r\n\t\t\t\t  where Licenses.LicenseClass=@LicenseClass;";



            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            {
                // إضافة المعاملات مع معالجة القيم الفارغة
                command.Parameters.AddWithValue("@LicenseClass", LicenseClass);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {


                        ClassFees = (decimal)reader["ClassFees"];


                    }
                    else
                    {

                    }

                    reader.Close();


                }
                catch (Exception ex)
                {
                    //Console.WriteLine("Error: " + ex.Message);}
                }


                finally
                {
                    connection.Close();
                }




            }
            return ClassFees;


        }


    






        static public decimal GetTheClassFeesByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {

            decimal ClassFees = -1;
            string query = "SELECT LicenseClasses.ClassFees\r\nFROM     LocalDrivingLicenseApplications INNER JOIN\r\n                  LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID\r\n\t\t\t\t  where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID;";



            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            {
                // إضافة المعاملات مع معالجة القيم الفارغة
                command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {


                        ClassFees = (decimal)reader["ClassFees"];


                    }
                    else
                    {

                    }

                    reader.Close();


                }
                catch (Exception ex)
                {
                    //Console.WriteLine("Error: " + ex.Message);}
                }


                finally
                {
                    connection.Close();
                }




            }
            return ClassFees;


        }


        static public int GetTheLicenseClassIDByClassName(string ClassName)
        {



            int LicenseClassID = 0;


            SqlConnection connection = new SqlConnection(Connection.ConnectionString);

            string query = "\r\n\t\t\t\t  select LicenseClasses.LicenseClassID from LicenseClasses\r\n\t\t\t\t  where LicenseClasses.ClassName=@ClassName;";
            SqlCommand command = new SqlCommand(query, connection);
            {
                // إضافة المعاملات مع معالجة القيم الفارغة
                command.Parameters.AddWithValue("@ClassName", ClassName);


            }


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {


                    LicenseClassID = (int)reader["LicenseClassID"];

                }
                else
                {

                }

                reader.Close();


            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return LicenseClassID;
        }


  
        static public DataTable GetAllClassName()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string quere = "select LicenseClasses.ClassName from LicenseClasses;";
            SqlCommand command = new SqlCommand(quere, connection);
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {



                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }






        static public int GetDefaultValidityLengthByClassName(string ClassName)
        {

            int DefaultValidityLength = 0;


            SqlConnection connection = new SqlConnection(Connection.ConnectionString);

            string query = "select LicenseClasses.DefaultValidityLength\r\n\t\t\t\t  from LicenseClasses where ClassName=@ClassName;";
            SqlCommand command = new SqlCommand(query, connection);
            {
                // إضافة المعاملات مع معالجة القيم الفارغة
                command.Parameters.AddWithValue("@ClassName", ClassName);
              

            }

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    DefaultValidityLength = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);}
            }


            finally
            {
                connection.Close();
            }


            return DefaultValidityLength;
        }


    }
}
