using ConnectionName;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDataAccessLayer
{
    public class ApplicationData
    {


        static public int AddNewRetakeApplication(int PersonID, DateTime ApplicationDate,int ApplicationTypeID,int ApplicationStatus,DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {

            int ApplicationID = -1;
            string query = "INSERT INTO [dbo].[Applications]\r\n           ([ApplicantPersonID]\r\n           ,[ApplicationDate]\r\n           ,[ApplicationTypeID]\r\n           ,[ApplicationStatus]\r\n           ,[LastStatusDate]\r\n           ,[PaidFees]\r\n           ,[CreatedByUserID])\r\n     VALUES\r\n\t (@PersonID,@ApplicationDate,@ApplicationTypeID,@ApplicationStatus,@LastStatusDate,@PaidFees,@CreatedByUserID)\r\n\t SELECT SCOPE_IDENTITY();";



            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            {
                // إضافة المعاملات مع معالجة القيم الفارغة
                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
                command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
                command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
                command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
                command.Parameters.AddWithValue("@PaidFees", PaidFees);
                command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);






                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();


                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        ApplicationID = insertedID;
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
            return ApplicationID;
        }



        static public decimal GetFeesApplicationByApplicationTypeID(int ApplicationTypeID)
        {

            decimal FeesApplication = -1;
            string query = " select ApplicationTypes.ApplicationFees from ApplicationTypes\r\n\t\t  where ApplicationTypeID=@ApplicationTypeID;";



            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            {
                // إضافة المعاملات مع معالجة القيم الفارغة
                command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {


                        FeesApplication = (decimal)reader["ApplicationFees"];


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
            return FeesApplication;
        }








        static public void UpdateStatusAndLastStatusDate(int ApplicationID, int Status, DateTime DateTime)
        {


            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string query = " UPDATE [dbo].[Applications]\r\n   SET [ApplicantPersonID] = ApplicantPersonID\r\n      ,[ApplicationDate] = ApplicationDate\r\n      ,[ApplicationTypeID] = ApplicationTypeID\r\n      ,[ApplicationStatus] =@Status\r\n      ,[LastStatusDate] =@DateTime\r\n      ,[PaidFees] = PaidFees\r\n      ,[CreatedByUserID] = CreatedByUserID\r\n WHERE ApplicationID=@ApplicationID;";


            SqlCommand command = new SqlCommand(query, connection);
            {
                // إضافة المعاملات مع معالجة القيم الفارغة
                command.Parameters.AddWithValue("@Status", Status);
                command.Parameters.AddWithValue("@DateTime", DateTime);
                command.Parameters.AddWithValue("@ApplicationID", ApplicationID);



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

        static public int AddNewApplication(int ApplicantPersonID,DateTime ApplicationDate,int ApplicationTypeID,int ApplicationStatus, DateTime LastStatusDate, int CreatedByUserID, decimal PaidFees)
        {

            int ApplicationID = -1;
            string query = "INSERT INTO [dbo].[Applications]\r\n       ([ApplicantPersonID]\r\n       ,[ApplicationDate]\r\n       ,[ApplicationTypeID]\r\n       ,[ApplicationStatus]\r\n       ,[LastStatusDate]\r\n       ,[PaidFees]\r\n       ,[CreatedByUserID])\r\nVALUES\r\n       (@ApplicantPersonID,\r\n        @ApplicationDate,\r\n        @ApplicationTypeID,\r\n        @ApplicationStatus,\r\n        @LastStatusDate,\r\n        @PaidFees,\r\n        @CreatedByUserID);\r\n\r\nSELECT SCOPE_IDENTITY();";



            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            {
                // إضافة المعاملات مع معالجة القيم الفارغة
                command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
                command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
                command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
                command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
                command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
                command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                command.Parameters.AddWithValue("@PaidFees", PaidFees);
      





                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();


                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        ApplicationID = insertedID;
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
            return ApplicationID;
        }



            static public void UpdateApplicationType(int ApplicationID  ,string ApplicationTitle, string ApplicationFees)
            {


            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string query = "UPDATE [dbo].[ApplicationTypes]\r\n   SET [ApplicationTypeTitle] =@ApplicationTitle\r\n      ,[ApplicationFees] =@ApplicationFees\r\n WHERE ApplicationTypeID=@ApplicationID;";
            SqlCommand command = new SqlCommand(query, connection);
            {
                // إضافة المعاملات مع معالجة القيم الفارغة
                command.Parameters.AddWithValue("@ApplicationTitle", ApplicationTitle);
                command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);
                command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

               
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




        static public DataTable GetAllApplicationType()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string quere = "select ApplicationTypes.ApplicationTypeID as [ID], \r\nApplicationTypes.ApplicationTypeTitle as [Title],\r\nApplicationTypes.ApplicationFees as [Fees] from ApplicationTypes;";


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

        static public DataTable GetOnlyApplicationTypeByID(int ApplicationID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string quere = "select * from ApplicationTypes\r\nwhere ApplicationTypes.ApplicationTypeID=@ApplicationID;";


            SqlCommand command = new SqlCommand(quere, connection);

            command.Parameters.AddWithValue("@ApplicationID",ApplicationID);
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





        static public bool FindTheApplicationByUserID(int UserID)

        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string query = "select * from Applications\r\nwhere CreatedByUserID=@UserID;";
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








//UPDATE [dbo].[ApplicationTypes]
//   SET [ApplicationTypeTitle] = 'd'
//      ,[ApplicationFees] = '54'
// WHERE ApplicationTypeID=1;
