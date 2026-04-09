using ConnectionName;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDataAccessLayer
{
    public class TestData
    {


        static public void AddNewTest(int TestAppointmentID,int TestResult,string Notes,int CreatedByUserID)
        {


            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string query = "\t   INSERT INTO [dbo].[Tests]\r\n           ([TestAppointmentID]\r\n           ,[TestResult]\r\n           ,[Notes]\r\n           ,[CreatedByUserID])\r\n     VALUES\r\n         (@TestAppointmentID,@TestResult,@Notes,@CreatedByUserID);";
            SqlCommand command = new SqlCommand(query, connection);
            {
                // إضافة المعاملات مع معالجة القيم الفارغة
                command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                command.Parameters.AddWithValue("@TestResult", TestResult);
               
                command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                command.Parameters.AddWithValue("@Notes",   string.IsNullOrEmpty(Notes) ? (object)DBNull.Value : Notes);




                try
                {
                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Record Updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Record Upadate failed.");
                    }



                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();

                }

            }

        }
        static public decimal GetFeesTypeByTestTypeID(int TestTypeID)
        {
            decimal Fees = 0;
            string query = "select TestTypes.TestTypeFees from TestTypes \r\nwhere TestTypeID=@TestTypeID;";




            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            {
                // إضافة المعاملات مع معالجة القيم الفارغة
                command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {


                        Fees = (decimal)reader["TestTypeFees"];


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



                return Fees;
            }

           
        }
        static public DataTable GetOnlyTestTypeByID(int TestTypeID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string quere = " select * from TestTypes\r\n where TestTypes.TestTypeID=@TestTypeID;";


            SqlCommand command = new SqlCommand(quere, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
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





        static public void UpdateTestType(int TestTypeID, string TestTypeFees, string TestTypeDescription,string TestTypeTitle)
        {


            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string query = "UPDATE [dbo].[TestTypes]\r\n   SET [TestTypeTitle] = @TestTypeTitle\r\n      ,[TestTypeDescription] = @TestTypeDescription\r\n      ,[TestTypeFees] = @TestTypeFees\r\n WHERE TestTypeID=@TestTypeID;";
            SqlCommand command = new SqlCommand(query, connection);
            {
                // إضافة المعاملات مع معالجة القيم الفارغة
                command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);
                command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
                command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);

                try
                {
                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Record Updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Record Upadate failed.");
                    }



                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();

                }

            }

        }




        static public DataTable GetAllTestType()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string quere = "select TestTypes.TestTypeID as [ID], \r\nTestTypes.TestTypeTitle as [Title],\r\nTestTypes.TestTypeDescription as [Description],\r\nTestTypes.TestTypeFees as [Fees] from TestTypes;";


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




        static public bool FindTheTestByUserID(int UserID)

        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string query = "select * from Tests\r\nwhere CreatedByUserID=@UserID;\r\n";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {



                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;


                }
                else
                {
                    // The record was not found
                    isFound = false;
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

            return isFound;
        }





    }
}




