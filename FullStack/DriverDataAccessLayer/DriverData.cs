using ConnectionName;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverDataAccessLayer
{
    public class DriverData
    {

        static public DataTable GetAllDataDriver()
        {


            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string query = "SELECT Drivers.DriverID, Drivers.PersonID, People.NationalNo, People.FirstName+' '+ People.SecondName+' '+ People.ThirdName+' '+ People.LastName+' ' as [Full Name]  , Drivers.CreatedDate\r\n,ActiveLicenses = (select TOP 1  Licenses.IsActive  from Licenses WHERE Licenses.DriverID = Drivers.DriverID)\r\n\r\nFROM     Drivers INNER JOIN\r\n                  People ON Drivers.PersonID = People.PersonID;\r\n";
            SqlCommand command = new SqlCommand(query, connection);


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



        static  public DataTable GetDataDriver(int LicenseID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string query = "SELECT  Class=\r\ncase \r\nwhen LicenseClass=1\t\tTHEN 'Class 1 - Small Motorcycle'\r\nwhen LicenseClass=2\t\tTHEN 'Class 2 - Heavy Motorcycle License'\r\nwhen LicenseClass=3\t\tTHEN 'Class 3 - Ordinary driving license'\r\nwhen LicenseClass=4\t\tTHEN 'Class 4 - Commercial'\r\nwhen LicenseClass=5 \tTHEN 'Class 5 - Agricultural'\r\nwhen LicenseClass=6 \tTHEN 'Class 6 - Small and medium bus'\r\nwhen LicenseClass=7\t\tTHEN 'Class 7 - Truck and heavy vehicle'\r\n\r\nEND\r\n,\r\n\r\nPeople.FirstName+' '+ People.SecondName+' '+ People.ThirdName+' '+ People.LastName as [Full Name], Licenses.LicenseID, People.NationalNo, Gendor=\r\nCase\r\n WHEN    Gendor=0   THEN'Male'\r\n WHEN    Gendor=1 THEN 'Female'\r\nEND\r\n,\r\n\r\nLicenses.IssueDate, IssueReason=\r\nCase \r\nwhen IssueReason=1 THEN'FirstTime'\r\nwhen IssueReason=2 THEN'Renew'\r\nwhen IssueReason=3 THEN'Replacement for Damaged'\r\nwhen IssueReason=4 THEN'Replacement for Lost'\r\nend,\r\n\r\nNotes\r\n,\r\n                IsActive=\r\n\t\t\t\tCase \r\n\t\t\t\twhen IsActive=1 THEN'True'\r\n\t\t\t    when IsActive=0 THEN 'False'\r\n\t\t\t\tend\r\n\t\t\t    , People.DateOfBirth, Licenses.DriverID, Licenses.ExpirationDate,\r\n\t\t\t\t\tIsDetained=\r\n\t\t\t\tcase \r\n\t\t\t\twhen ExpirationDate=GETDATE() Then 'Yes'\r\n\t\t\t\tELSE 'No'\r\n\t\t\t\tend\r\n\t\t\t\r\nFROM     Licenses INNER JOIN\r\n                  Drivers ON Licenses.DriverID = Drivers.DriverID INNER JOIN\r\n                  People ON Drivers.PersonID = People.PersonID\r\n\t\t\t\t  where Licenses.LicenseID=@LicenseID;";
            SqlCommand command = new SqlCommand(query, connection);

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

        static public int GetDriverIDByPersonID(int PersonID)
        {

            int DriverID = -1;
            string query = "SELECT Drivers.DriverID\r\nFROM     Drivers INNER JOIN\r\n                  People ON Drivers.PersonID= People.PersonID\r\n\t\t\t\t  where Drivers.PersonID=@PersonID;";



            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            {
                // إضافة المعاملات مع معالجة القيم الفارغة
                command.Parameters.AddWithValue("@PersonID", PersonID);
        







                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();


                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        DriverID = insertedID;
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
            return DriverID;
        }




        static public int AddNewDriver(int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {

            int DriverID = -1;
            string query = "INSERT INTO [dbo].[Drivers]\r\n           ([PersonID]\r\n           ,[CreatedByUserID]\r\n           ,[CreatedDate])\r\n     VALUES\r\n         (@PersonID,@CreatedByUserID,@CreatedDate);";



            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            {
                // إضافة المعاملات مع معالجة القيم الفارغة
                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
          






                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();


                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                       DriverID = insertedID;
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
            return DriverID;
        }



        static public bool FindTheDriverByUserID(int UserID)

        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string query = "select * from Drivers\r\nwhere CreatedByUserID=@UserID;";
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
