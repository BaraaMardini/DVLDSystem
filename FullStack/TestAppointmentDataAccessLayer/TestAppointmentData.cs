using ConnectionName;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TestAppointmentDataAccessLayer
{
    public class TestAppointmentData
    {



        static public bool GetLastPassedTestAppointmentID(int TestResult, int LocalDrivingLicenseApplicationID, int TestTypeID)
        {


            bool isFound = false;
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);

            string query = "\r\n\t\t\t\t   SELECT top 1 TestAppointments.TestAppointmentID\r\nFROM     TestAppointments INNER JOIN\r\n                  Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID\r\n\r\n\t\t\t\t  where TestResult=@TestResult and LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID  and TestAppointments.TestTypeID=@TestTypeID\r\n\t\t\t\t  Order By TestAppointmentID desc;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestResult", TestResult);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

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
                //  Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isFound;

        }


        static public void UpdateTestAppointment(int TestAppointmentID)
        {


            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string query = " UPDATE [dbo].[TestAppointments]\r\n   SET [TestTypeID] = TestTypeID\r\n      ,[LocalDrivingLicenseApplicationID] = LocalDrivingLicenseApplicationID\r\n      ,[AppointmentDate] = AppointmentDate\r\n      ,[PaidFees] = PaidFees\r\n      ,[CreatedByUserID] = CreatedByUserID\r\n      ,[IsLocked] = 1\r\n      ,[RetakeTestApplicationID] = RetakeTestApplicationID\r\n WHERE\t\tTestAppointmentID=@TestAppointmentID;";
            SqlCommand command = new SqlCommand(query, connection);
            {
                // إضافة المعاملات مع معالجة القيم الفارغة
                command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
        



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








        static public DateTime GetAppointmentDateByAppointmentID(int TestAppointmentID)
        {
            DateTime AppointmentDate= DateTime.Now;
            string query = "select TestAppointments.AppointmentDate\r\n\t  from TestAppointments\r\n\t  where TestAppointments.TestAppointmentID=@TestAppointmentID;";




            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            {
                // إضافة المعاملات مع معالجة القيم الفارغة
                command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);








                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {


                        AppointmentDate = (DateTime)reader["TestTypeFees"];


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


                return AppointmentDate;
            }
            }
        




            static public bool IsTestTypeActive(int IsLocked, int TestTypeID,string ClassName, int LocalDrivingLicenseApplicationID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);

            string query = "\t\t\t\tSELECT TestAppointments.TestAppointmentID FROM     TestAppointments INNER JOIN            \r\n\t\tLocalDrivingLicenseApplications ON TestAppointments.LocalDrivingLicenseApplicationID = \r\n\t\tLocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID INNER JOIN  \r\n\t\tLicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID\r\n\t\twhere IsLocked=@IsLocked and TestTypeID=@TestTypeID and ClassName=@ClassName and LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID =@LocalDrivingLicenseApplicationID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@IsLocked", IsLocked);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            command.Parameters.AddWithValue("@ClassName", ClassName);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

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
                //  Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }




        public static DataTable GetTestAppointmentByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID,int TestTypeID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);

            //  string query = "SELECT * FROM People WHERE PersonID = @PersonID";
            string query = " select TestAppointments.TestAppointmentID as [Appointment ID],TestAppointments.AppointmentDate as [Appointment Date],\r\n\t\t   TestAppointments.PaidFees as [Peaid Fees],TestAppointments.IsLocked as [Is Locked ] from TestAppointments\r\n\t\t   where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID and TestTypeID=@TestTypeID;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
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



        static public bool FindTheTestAppointmentIfLocked(int IsLocked, int LocalDrivingLicenseApplicationID,string ClassName,int TestType)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);

            string query = "SELECT TestAppointments.TestAppointmentID\r\nFROM     TestAppointments INNER JOIN\r\n                  LocalDrivingLicenseApplications ON TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID INNER JOIN\r\n                  LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID\r\n\t\twhere TestAppointments.IsLocked=@IsLocked and TestAppointments.TestTypeID=@TestTypeID and \r\n\t\tTestAppointments.LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID and LicenseClasses.ClassName=@ClassName;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@IsLocked", IsLocked);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@ClassName", ClassName);
            command.Parameters.AddWithValue("@TestType", TestType);



            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

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
                //  Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }












        static public  int GetLastTestAppointmentID(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            int LastTestAppointmentID = -1;
            string query = " select top (1) TestAppointments.TestAppointmentID from TestAppointments\r\n\t\t   where TestAppointments.LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID and TestAppointments.TestTypeID=@TestTypeID\r\n\t\t   ORDER BY TestAppointmentID DESC;";




            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            {
                // إضافة المعاملات مع معالجة القيم الفارغة
                command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                command.Parameters.AddWithValue("@TestTypeID", TestTypeID);






                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();


                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        LastTestAppointmentID = insertedID;
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


                return LastTestAppointmentID;

            }
        }




        static public void AddNewAppointment(int TestTypeID, int LocalDrivingApplication,DateTime AppointmentDate, decimal Fees,int CreatedByUserID, int IsLocked,int RetakeTestApplicationID)
        {

            string query;
            
            if (RetakeTestApplicationID == 0)
            {


                 query = "INSERT INTO [dbo].[TestAppointments]\r\n           ([TestTypeID]\r\n           ,[LocalDrivingLicenseApplicationID]\r\n           ,[AppointmentDate]\r\n           ,[PaidFees]\r\n           ,[CreatedByUserID]\r\n           ,[IsLocked]\r\n           ,[RetakeTestApplicationID])\r\n     VALUES\r\n\t\t (@TestTypeID,@LocalDrivingApplication,@AppointmentDate,@Fees,@CreatedByUserID,@IsLocked,NULL);";
            }
            else
            {
                query = "INSERT INTO [dbo].[TestAppointments]\r\n           ([TestTypeID]\r\n           ,[LocalDrivingLicenseApplicationID]\r\n           ,[AppointmentDate]\r\n           ,[PaidFees]\r\n           ,[CreatedByUserID]\r\n           ,[IsLocked]\r\n           ,[RetakeTestApplicationID])\r\n     VALUES\r\n\t\t (@TestTypeID,@LocalDrivingApplication,@AppointmentDate,@Fees,@CreatedByUserID,@IsLocked,@RetakeTestApplicationID);";
            
             }

            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            {
                // إضافة المعاملات مع معالجة القيم الفارغة
                command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                command.Parameters.AddWithValue("@LocalDrivingApplication", LocalDrivingApplication);
                command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                command.Parameters.AddWithValue("@Fees",    Fees);
                command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                command.Parameters.AddWithValue("@IsLocked", IsLocked);

                command.Parameters.AddWithValue("@RetakeTestApplicationID",RetakeTestApplicationID);
              
     





                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();


                  
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
        }


    }
}
