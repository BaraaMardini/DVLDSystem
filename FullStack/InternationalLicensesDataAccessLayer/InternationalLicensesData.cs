using ConnectionName;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalLicensesDataAccessLayer
{
    public class InternationalLicensesData
    {



        //        SELECT InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive =
        //Case

        //                when ExpirationDate >= GETDATE() THEN '1'
        //				ELSE '0'
        //				END,

        //				CreatedByUserID
        //FROM     InternationalLicenses
        //where IssuedUsingLocalLicenseID=@IssuedUsingLocalLicenseID and IsActive=1



        static public DataTable GetAllInternationalLicenses()
        {


            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string quere = "SELECT InternationalLicenseID as[Int.License ID], ApplicationID as [Application ID], DriverID as [Driver ID], IssuedUsingLocalLicenseID as [L.License ID], IssueDate as [Issue Date], ExpirationDate as [Expiration Date], IsActive as [Is Active]\r\nFROM     InternationalLicenses";

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

        static public DataTable GetInterNationalLicenseByIssuedUsingLocalLicenseID(int IssuedUsingLocalLicenseID)
        {







            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string quere = "\r\n\r\nSELECT InternationalLicenseID as[Int.License ID], ApplicationID as [Application ID], DriverID as [Driver ID], IssuedUsingLocalLicenseID as [L.License ID], IssueDate as [Issue Date], ExpirationDate as [Expiration Date], IsActive as [Is Active]\r\nFROM     InternationalLicenses\r\nwhere IssuedUsingLocalLicenseID=@IssuedUsingLocalLicenseID;\r\n";

            SqlCommand command = new SqlCommand(quere, connection);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);

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


        static public DataTable GetInterNationalLicenseByILID(int InternationalLicenseID) {







            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string quere = "SELECT People.FirstName+' ' +People.SecondName+' '+ People.ThirdName+' '+\r\nPeople.LastName as [Full Name] ,InternationalLicenses.InternationalLicenseID, Licenses.LicenseID, People.NationalNo, Gendor=\r\ncase \r\nwhen People.Gendor=1 then'Male'\r\nelse 'Female'\r\nend,\r\n\r\nInternationalLicenses.IssueDate, \r\n                  Licenses.ApplicationID, IsActive=\r\n\t\t\t\t  case \r\n\t\t\t\t  when InternationalLicenses.IsActive=1 then 'Yes'\r\n\t\t\t\t  else 'No'\r\n\t\t\t\t  end\r\n \t\t\t\t\r\n\t\t\t\t  , People.DateOfBirth, Licenses.DriverID, InternationalLicenses.ExpirationDate\r\nFROM     InternationalLicenses INNER JOIN\r\n                  Licenses ON InternationalLicenses.IssuedUsingLocalLicenseID = Licenses.LicenseID INNER JOIN\r\n                  Drivers ON InternationalLicenses.DriverID = Drivers.DriverID INNER JOIN\r\n                  People ON Drivers.PersonID = People.PersonID\r\n\r\n\t\t\t\t  where InternationalLicenseID=@InternationalLicenseID;";
          
       
            SqlCommand command = new SqlCommand(quere, connection);
            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
         
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

        static public int AddNewInternationalLicense(int ApplicationID,  int IssuedUsingLocalLicenseID, int IsActive, DateTime IssueDate, int CreatedByUserID,DateTime ExpirationDate, int DriverID)
        {

            int InternationalLicenseID = -1;
            string query = "INSERT INTO [dbo].[InternationalLicenses]   ([ApplicationID]    ,[DriverID]     ,[IssuedUsingLocalLicenseID]\r\n,[IssueDate]      ,[ExpirationDate]   ,[IsActive]      ,[CreatedByUserID])  \r\nVALUES( @ApplicationID,@DriverID,   @IssuedUsingLocalLicenseID,    @IssueDate,   @ExpirationDate,   @IsActive,     @CreatedByUserID  )\r\nSELECT SCOPE_IDENTITY();";



            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            {
                // إضافة المعاملات مع معالجة القيم الفارغة
                command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
                command.Parameters.AddWithValue("@IssueDate", IssueDate);
                command.Parameters.AddWithValue("@IsActive", IsActive);
                command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                command.Parameters.AddWithValue("@DriverID", DriverID);
                //DriverID






                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();


                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        InternationalLicenseID = insertedID;
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
            return InternationalLicenseID;
        }

        static public bool FindTheInternationalLicenseByLicenseID(int IssuedUsingLocalLicenseID)
        {
            

            bool isFound = false;
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);

            string query = "select * from InternationalLicenses\r\n\t\t\t\t\twhere IssuedUsingLocalLicenseID=@IssuedUsingLocalLicenseID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
         


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
