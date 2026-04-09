using ConnectionName;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetainedLicensesDataAccessLayer
{
    public class DetainedLicensesData
    {

        static public DataTable GetAllDetainedLicenses()
        {


            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string quere = "SELECT DetainedLicenses.DetainID as [Detain ID], DetainedLicenses.LicenseID as [License ID], \r\nDetainedLicenses.DetainDate as [Detain Date],\r\nDetainedLicenses.IsReleased as [Is Released], DetainedLicenses.FineFees as [Fine Fees], \r\nDetainedLicenses.ReleaseDate as [Release Date], People.NationalNo as [National No], People.FirstName+' ' +\r\n                  People.SecondName+' '+ People.ThirdName+' '+ People.LastName as [Full Name], DetainedLicenses.ReleaseApplicationID as [Release Application ID]\r\nFROM     DetainedLicenses INNER JOIN\r\n                  Licenses ON DetainedLicenses.LicenseID = Licenses.LicenseID INNER JOIN\r\n                  Drivers ON Licenses.DriverID = Drivers.DriverID INNER JOIN\r\n                  People ON Drivers.PersonID = People.PersonID";

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





        static public void UpdateDetainLicense(int IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID, int DetainID)

        {
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string query = "UPDATE [dbo].[DetainedLicenses]\r\n   SET [LicenseID] =\tLicenseID\r\n      ,[DetainDate] = DetainDate\r\n      ,[FineFees] = FineFees\r\n      ,[CreatedByUserID] = CreatedByUserID\r\n      ,[IsReleased] = @IsReleased\r\n      ,[ReleaseDate] =@ReleaseDate\r\n      ,[ReleasedByUserID] = @ReleasedByUserID\r\n      ,[ReleaseApplicationID] = @ReleaseApplicationID\r\n WHERE DetainedLicenses.DetainID=@DetainID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);
            command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            command.Parameters.AddWithValue("@DetainID", DetainID);




            try
            {
                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                  //  Console.WriteLine("Record Updated successfully.");
                }
                else
                {
                   // Console.WriteLine("Record Upadate failed.");
                }



            }
            catch (Exception ex)
            {
          //      Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();

            }

        }




        static public DataTable GetDetainedLicenseByLicenseID(int LicenseID)
        {


                DataTable dt = new DataTable();
                SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string quere = "select top(1) * from DetainedLicenses\r\nwhere LicenseID=@LicenseID\r\n  order  by  DetainID desc ;";



                SqlCommand command = new SqlCommand(quere, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
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



        static public bool CheakLicenseIDIsReleased(int LicenseID, int IsReleased)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);

            string query = "select  DetainedLicenses.LicenseID from DetainedLicenses\r\nwhere DetainedLicenses.LicenseID=@LicenseID and DetainedLicenses.IsReleased=@IsReleased;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);




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

        public static int AddNewDetainedLicense(int LicenseID, DateTime DetainDate,decimal FineFees,int CreatedByUserID,int IsReleased)
        {




            int DetainedID = -1;
            string query = "INSERT INTO [dbo].[DetainedLicenses]\r\n           ([LicenseID]\r\n           ,[DetainDate]\r\n           ,[FineFees]\r\n           ,[CreatedByUserID]\r\n           ,[IsReleased]\r\n           ,[ReleaseDate]\r\n           ,[ReleasedByUserID]\r\n           ,[ReleaseApplicationID])\r\n     VALUES\r\n       (@LicenseID,@DetainDate,@FineFees,@CreatedByUserID,@IsReleased,null,null,null)\r\n\t   SELECT SCOPE_IDENTITY();";



            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            {
                // إضافة المعاملات مع معالجة القيم الفارغة
                command.Parameters.AddWithValue("@LicenseID", LicenseID);
                command.Parameters.AddWithValue("@DetainDate", DetainDate);
                command.Parameters.AddWithValue("@FineFees", FineFees);
                command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                command.Parameters.AddWithValue("@IsReleased", IsReleased);





                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();


                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        DetainedID = insertedID;
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


                return DetainedID;

            }

        }


    }
}
