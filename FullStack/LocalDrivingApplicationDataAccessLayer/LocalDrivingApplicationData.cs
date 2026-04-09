using ConnectionName;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace LocalDrivingApplicationDataAccessLayer
{
    public class LocalDrivingApplicationData
    {
        
        static public int GetPersonIDByLocalDrivingApplicationID(int LocalDrivingLicenseApplicationID)
        {

            int PersonID = -1;
            string query = "\r\n SELECT People.PersonID\r\nFROM     LocalDrivingLicenseApplications INNER JOIN\r\n                  Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID INNER JOIN\r\n                  People ON Applications.ApplicantPersonID = People.PersonID\r\n\t\t\t\t  where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID;";



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
                        PersonID= insertedID;
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


                return PersonID;

            }


        }




        static public int GetApplicationIDByLocalDriveApplicationID(int LocalDriveApplicationID)
        {

            int LocalDrivingApplicationID = -1;
            string query = " select LocalDrivingLicenseApplications.ApplicationID from LocalDrivingLicenseApplications\r\n where LocalDrivingLicenseApplicationID=@LocalDriveApplicationID;";



            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            {
                // إضافة المعاملات مع معالجة القيم الفارغة
                command.Parameters.AddWithValue("@LocalDriveApplicationID", LocalDriveApplicationID);
              






                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();


                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        LocalDrivingApplicationID = insertedID;
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


                return LocalDrivingApplicationID;

            }
        }










        static public int AddNewLocalDrivingApplication(int ApplicationID,int LicenseClassID)
        {

            int LocalDrivingApplicationID = -1;
            string query = "INSERT INTO [dbo].[LocalDrivingLicenseApplications]\r\n           ([ApplicationID]\r\n           ,[LicenseClassID])\r\n     VALUES\r\n         (@ApplicationID,@LicenseClassID)\r\n\t\t SELECT SCOPE_IDENTITY();";



            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            {
                // إضافة المعاملات مع معالجة القيم الفارغة
                command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
                





                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();


                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        LocalDrivingApplicationID = insertedID;
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


                return LocalDrivingApplicationID;

            }
        }




            static public DataTable GetAllLocalDrivingApplicationData()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string quere = "select LocalDrivingLicenseApplications_View.LocalDrivingLicenseApplicationID as[L.D.L.AppID], LocalDrivingLicenseApplications_View.ClassName as [Driving Class]\r\n,LocalDrivingLicenseApplications_View.NationalNo[National NO],LocalDrivingLicenseApplications_View.FullName as [Full Name],LocalDrivingLicenseApplications_View.ApplicationDate[Application Data]\r\n,LocalDrivingLicenseApplications_View.PassedTestCount as [Passed Test] , LocalDrivingLicenseApplications_View.Status as [Status] from LocalDrivingLicenseApplications_View;";


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









    }
}
