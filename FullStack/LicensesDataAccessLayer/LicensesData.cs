using ConnectionName;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicensesDataAccessLayer
{
    public class LicensesData
    {
        //IsLicenseOutOfDate

        static public bool CheakLicenseIDIfLicenseClassIs3(int LicenseID, int LicenseClass)
        {




            bool isFound = false;
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string query = "\r\nselect * from Licenses\r\nwhere LicenseID=@LicenseID and LicenseClass=@LicenseClass;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);


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

        static public bool CheakTheLicenseIDIsActive(int LicenseID)

        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string query = "\r\n\t  select Licenses.LicenseID from Licenses\r\n\t  where Licenses.IsActive=0  and LicenseID=@LicenseID;\r\n";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

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



        static public void UpdatePersonInfo(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string query = "\r\nUPDATE [dbo].[Licenses]\r\n   SET [ApplicationID] = ApplicationID\r\n      ,[DriverID] = DriverID\r\n      ,[LicenseClass] =LicenseClass\r\n      ,[IssueDate] = IssueDate\r\n      ,[ExpirationDate] = ExpirationDate\r\n      ,[Notes] = Notes\r\n      ,[PaidFees] = PaidFees\r\n      ,[IsActive] = 0\r\n      ,[IssueReason] =IssueReason\r\n      ,[CreatedByUserID] = CreatedByUserID\r\n\t  where LicenseID=@LicenseID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
  

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

        static public int GetLicenseClassByLicenseID(int LicenseID)
        {

            int LicenseClass = -1;
            string query = "select Licenses.LicenseClass from Licenses \r\nwhere LicenseID=@LicenseID;";



            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            {
                // إضافة المعاملات مع معالجة القيم الفارغة
                command.Parameters.AddWithValue("@LicenseID", LicenseID);

                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();


                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        LicenseClass = insertedID;
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




            }
            return LicenseClass;


        }

        static public  DateTime  GetExpirationDateByLicenseID(int LicenseID)
        {
            DateTime ExpirationDate=DateTime.Now;
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            //  string query = "SELECT * FROM People WHERE PersonID = @PersonID";
            string query = "select Licenses.ExpirationDate from Licenses\r\nwhere Licenses.LicenseID=@LicenseID;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {


                    ExpirationDate = (DateTime)reader["ExpirationDate"];


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

            return ExpirationDate;
        }




        static public bool FindTheLicenseIDByLicenseID(int LicenseID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);

            string query = "select Licenses.LicenseID from Licenses\r\n\twhere LicenseID=@LicenseID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);



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



        static public  bool CheckClass3LocalLicense(int LicenseID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);

            string query = "SELECT Licenses.LicenseID\r\nFROM     Licenses INNER JOIN\r\n                  LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID\r\n\t\t\t\t    where Licenses.LicenseID=@LicenseID and LicenseClasses.ClassName='Class 3 - Ordinary driving license';";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);



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



    
    static public DataTable GetInfoLicense(int DriverID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string query = "SELECT LicenseID, ApplicationID, \r\nClass= \r\ncase \r\nwhen LicenseClass=1 THEN 'Class 1 - Small Motorcycle' \r\nwhen LicenseClass=2 THEN 'Class 2 - Heavy Motorcycle License'\r\n\r\nwhen LicenseClass=3 THEN 'Class 3 - Ordinary driving license'\r\nwhen LicenseClass=4 THEN 'Class 4 - Commercial'\r\nwhen LicenseClass=5 THEN 'Class 5 - Agricultural'\r\nwhen LicenseClass=6 THEN 'Class 6 - Small and medium bus'\r\nwhen LicenseClass=7 THEN 'Class 7 - Truck and heavy vehicle'\r\n\r\nend,\r\n\r\nIssueDate, ExpirationDate, IsActive\r\nFROM     Licenses\r\nwhere DriverID=@DriverID;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);

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




 
       static public int GetLicenseIDByLocalDrivingLicenseApplications(int LocalDrivingLicenseApplicationID)
        {

            int LicenseID = -1;
            string query = "SELECT Licenses.LicenseID\r\nFROM     Licenses INNER JOIN\r\n                  Applications ON Licenses.ApplicationID = Applications.ApplicationID INNER JOIN\r\n                  LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID\r\n\t\t\t\t  where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID;";



            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            {
                // إضافة المعاملات مع معالجة القيم الفارغة
                command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();


                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        LicenseID = insertedID;
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




            }
            return LicenseID;


        }


        static public int AddNewLicense(int ApplicationID,int DriverID,int LicenseClass, DateTime IssueDate, DateTime ExpirationDate,string Notes,decimal PaidFees,int IsActive, int IssueReason, int CreatedByUserID)
        {

            int CountOfTest = -1;
            string query = "";
           if(Notes.Length > 1)
            {
                query = "INSERT INTO [dbo].[Licenses]\r\n           ([ApplicationID]\r\n           ,[DriverID]\r\n           ,[LicenseClass]\r\n           ,[IssueDate]\r\n           ,[ExpirationDate]\r\n           ,[Notes]\r\n           ,[PaidFees]\r\n           ,[IsActive]\r\n           ,[IssueReason]\r\n           ,[CreatedByUserID])\r\n     VALUES\r\n      (@ApplicationID,@DriverID,@LicenseClass,@IssueDate,@ExpirationDate,@Notes,@PaidFees,@IsActive,@IssueReason,@CreatedByUserID);\r\nSELECT SCOPE_IDENTITY();";
            }
           else
            {
                 query = "INSERT INTO [dbo].[Licenses]\r\n           ([ApplicationID]\r\n           ,[DriverID]\r\n           ,[LicenseClass]\r\n           ,[IssueDate]\r\n           ,[ExpirationDate]\r\n           ,[Notes]\r\n           ,[PaidFees]\r\n           ,[IsActive]\r\n           ,[IssueReason]\r\n           ,[CreatedByUserID])\r\n     VALUES\r\n      (@ApplicationID,@DriverID,@LicenseClass,@IssueDate,@ExpirationDate,NULL,@PaidFees,@IsActive,@IssueReason,@CreatedByUserID)\r\nSELECT SCOPE_IDENTITY();";

            }





            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            {
                // إضافة المعاملات مع معالجة القيم الفارغة
                command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                command.Parameters.AddWithValue("@DriverID", DriverID);
                command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
                command.Parameters.AddWithValue("@IssueDate", IssueDate);
                command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                command.Parameters.AddWithValue("@Notes", Notes);
                command.Parameters.AddWithValue("@PaidFees", PaidFees);
                command.Parameters.AddWithValue("@IsActive", IsActive);
                command.Parameters.AddWithValue("@IssueReason", IssueReason);
                command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();


                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        CountOfTest = insertedID;
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


                return CountOfTest;

            }
        }
    }
}
