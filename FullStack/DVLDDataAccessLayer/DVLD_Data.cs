using ConnectionName;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer
{
    public class DVLD_Data
    {

        static public bool IsThePersonDrive( int PersonID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);

            string query = " select * from Drivers\r\n where PersonID=@PersonID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);


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


        static public int CountOfTestRepeat(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {

            int CountOfTest = -1;
            string query = "select count( LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID)\r\nFROM     LocalDrivingLicenseApplications INNER JOIN\r\n                  TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN\r\n                  Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID INNER JOIN\r\n                  TestTypes ON TestAppointments.TestTypeID = TestTypes.TestTypeID\r\n\t\t\t\t  where TestAppointments.LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID and TestTypes.TestTypeID=@TestTypeID;";




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






        static public int GetPassedTestCountByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {

            int PassedTestCount = -1;
            string query = "select LocalDrivingLicenseApplications_View.PassedTestCount\r\nfrom LocalDrivingLicenseApplications_View\r\nwhere LocalDrivingLicenseApplications_View.LocalDrivingLicenseApplicationID =@LocalDrivingLicenseApplicationID;";




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
                        PassedTestCount = insertedID;
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


                return PassedTestCount;

            }
        }



    






        static public DataTable GetAllLocalDrivingLicenseApplications(int LocalDrivingLicenseApplicationID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            //  string query = "SELECT * FROM People WHERE PersonID = @PersonID";
            string query = "\r\nSELECT LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID, Applications.ApplicationID, ApplicationTypes.ApplicationTypeTitle,\r\nApplications.CreatedByUserID\r\n\r\n, LicenseClasses.ClassName, Applications.ApplicationDate, \r\n                  Applications.LastStatusDate,\r\n\t\t\t\t  Status=\r\n\t\t\t\t  case\r\n\t\t\t\t  when ApplicationStatus=1 THEN 'New'\r\n\t\t\t\t  when ApplicationStatus=2 THEN 'Cancelled'\r\n\t\t\t\t  when ApplicationStatus=3 THEN 'Completed'\r\n\t\t\t\t  END\r\n\t\t\t\t  , People.FirstName+' '+People.SecondName+' '\r\n\t\t\t\t + ' '+People.ThirdName+' '+People.LastName as[FullName] ,People.PersonID\r\nFROM     LocalDrivingLicenseApplications INNER JOIN\r\n                  Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID INNER JOIN\r\n                  LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID INNER JOIN\r\n                  ApplicationTypes ON Applications.ApplicationTypeID = ApplicationTypes.ApplicationTypeID INNER JOIN\r\n                  People ON Applications.ApplicantPersonID = People.PersonID\r\n\t\t\t\t  where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID;";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

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
        static public bool ValidateNewLocalApplication(string LicenseClass,int PersonID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);

            string query = "\t\t\t\tSELECT  Number=1\r\nFROM     Applications INNER JOIN\r\n                  People ON Applications.ApplicantPersonID = People.PersonID INNER JOIN\r\n                  LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID INNER JOIN\r\n                  LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID\r\n\t\t\t\t where ClassName=@LicenseClass and ApplicationStatus=1 and PersonID=@PersonID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            command.Parameters.AddWithValue("@PersonID", PersonID);


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







    }
}
