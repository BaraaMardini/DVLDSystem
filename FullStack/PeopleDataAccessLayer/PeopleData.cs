using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using ConnectionName;
namespace PeopleDataAccessLayer
{
    public class PeopleData
    {


        public static int GetPersonIDByLicenseID(int LicenseID)
        {


            int PersonID = -1;
            string query = "SELECT People.PersonID\r\nFROM     Licenses INNER JOIN\r\n                  Drivers ON Licenses.DriverID = Drivers.DriverID INNER JOIN\r\n                  People ON Drivers.PersonID = People.PersonID\r\n\t\t\t\t  where Licenses.LicenseID=@LicenseID;";



            using (SqlConnection connection = new SqlConnection(Connection.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // إضافة المعاملات مع معالجة القيم الفارغة
                command.Parameters.AddWithValue("@LicenseID", LicenseID);






                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();


                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        PersonID = insertedID;
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




            }
            return PersonID;

        }
            
        






        public static DataTable GetPersonByPersonID1(int PersonID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            //  string query = "SELECT * FROM People WHERE PersonID = @PersonID";
            string query = "SELECT People.PersonID, People.NationalNo, People.FirstName, People.SecondName, People.ThirdName, People.LastName, People.Gendor, People.DateOfBirth, Countries.CountryName, People.Phone, People.Email,People.Address\r\nFROM     People INNER JOIN\r\n                  Countries ON People.NationalityCountryID = Countries.CountryID\r\n\t\t\t\t  where PersonID=@PersonID;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

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


        static public DataTable GetAllPersonData()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string quere = "      SELECT  People.PersonID AS [Person ID], People.NationalNo as[National NO ], People.FirstName as [First Name], People.SecondName as" +
                " [Second Name ],\r\nPeople.ThirdName as [Third Name ], People.LastName as [Last Name ], People.Gendor, " +
                "People.DateOfBirth as [Date Of Birth], Countries.CountryName as [Nationalty], People.Phone, People.Email\r\nFROM  " +
                "   People INNER JOIN\r\n                  Countries ON People.NationalityCountryID = Countries.CountryID       ";

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




        public static DataTable GetPersonByPersonID(int PersonID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            //  string query = "SELECT * FROM People WHERE PersonID = @PersonID";
            string query = "\t\t\t      SELECT  People.PersonID AS [Person ID], People.NationalNo as[National NO ], People.FirstName as [First Name], People.SecondName as \r\n         [Second Name ], People.ThirdName as [Third Name ], People.LastName as [Last Name ], People.Gendor, \r\n        People.DateOfBirth as [Date Of Birth], Countries.CountryName as [Nationalty], People.Phone, People.Email FROM  \r\n          People INNER JOIN               Countries ON People.NationalityCountryID = Countries.CountryID      \r\n\t\t  where PersonID= @PersonID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

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


        public static DataTable GetPersonByFirstName(string FirstName)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string query = "\r\n\t\t\t\t      SELECT  People.PersonID AS [Person ID], People.NationalNo as[National NO ], People.FirstName as [First Name], People.SecondName as \r\n         [Second Name ], People.ThirdName as [Third Name ], People.LastName as [Last Name ], People.Gendor, \r\n        People.DateOfBirth as [Date Of Birth], Countries.CountryName as [Nationalty], People.Phone, People.Email FROM  \r\n          People INNER JOIN               Countries ON People.NationalityCountryID = Countries.CountryID      \r\n\t\t  where FirstName=@FirstName";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);

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





        public static DataTable GetPersonBySecondName(string SecondName)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string query = "\r\n\r\n\t\t\t\t      SELECT  People.PersonID AS [Person ID], People.NationalNo as[National NO ], People.FirstName as [First Name], People.SecondName as \r\n         [Second Name ], People.ThirdName as [Third Name ], People.LastName as [Last Name ], People.Gendor, \r\n        People.DateOfBirth as [Date Of Birth], Countries.CountryName as [Nationalty], People.Phone, People.Email FROM  \r\n          People INNER JOIN               Countries ON People.NationalityCountryID = Countries.CountryID      \r\n\t\t  where SecondName=@SecondName";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@SecondName", SecondName);

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


        public static DataTable GetPersonByThirdName(string ThirdName)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string query = "\r\n\t\t\t\t      SELECT  People.PersonID AS [Person ID], People.NationalNo as[National NO ], People.FirstName as [First Name], People.SecondName as \r\n         [Second Name ], People.ThirdName as [Third Name ], People.LastName as [Last Name ], People.Gendor, \r\n        People.DateOfBirth as [Date Of Birth], Countries.CountryName as [Nationalty], People.Phone, People.Email FROM  \r\n          People INNER JOIN               Countries ON People.NationalityCountryID = Countries.CountryID      \r\n\t\t  where ThirdName=@ThirdName";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ThirdName", ThirdName);

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

        public static DataTable GetPersonByLastName(string LastName)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string query = "\t\t      SELECT  People.PersonID AS [Person ID], People.NationalNo as[National NO ], People.FirstName as [First Name], People.SecondName as \r\n         [Second Name ], People.ThirdName as [Third Name ], People.LastName as [Last Name ], People.Gendor, \r\n        People.DateOfBirth as [Date Of Birth], Countries.CountryName as [Nationalty], People.Phone, People.Email FROM  \r\n          People INNER JOIN               Countries ON People.NationalityCountryID = Countries.CountryID      \r\n\t\t  where LastName=@LastName";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LastName", LastName);

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

        public static DataTable GetPersonByEmail(string Email)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);

            string query = "\t\t\t\t      SELECT  People.PersonID AS [Person ID], People.NationalNo as[National NO ], People.FirstName as [First Name], People.SecondName as \r\n         [Second Name ], People.ThirdName as [Third Name ], People.LastName as [Last Name ], People.Gendor, \r\n        People.DateOfBirth as [Date Of Birth], Countries.CountryName as [Nationalty], People.Phone, People.Email FROM  \r\n          People INNER JOIN               Countries ON People.NationalityCountryID = Countries.CountryID      \r\n\t\t  where Email=@Email";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Email", Email);

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


        public static DataTable GetPersonByPhone(int Phone)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string query = "\t\t\t      SELECT  People.PersonID AS [Person ID], People.NationalNo as[National NO ], People.FirstName as [First Name], People.SecondName as \r\n         [Second Name ], People.ThirdName as [Third Name ], People.LastName as [Last Name ], People.Gendor, \r\n        People.DateOfBirth as [Date Of Birth], Countries.CountryName as [Nationalty], People.Phone, People.Email FROM  \r\n          People INNER JOIN               Countries ON People.NationalityCountryID = Countries.CountryID      \r\n\t\t  where phone=@Phone";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Phone", Phone);

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



        public static DataTable GetPersonByGendor(string Gendor)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string query = "\t\t\t      SELECT  People.PersonID AS [Person ID], People.NationalNo as[National NO ], People.FirstName as [First Name], People.SecondName as \r\n         [Second Name ], People.ThirdName as [Third Name ], People.LastName as [Last Name ], People.Gendor, \r\n        People.DateOfBirth as [Date Of Birth], Countries.CountryName as [Nationalty], People.Phone, People.Email FROM  \r\n          People INNER JOIN               Countries ON People.NationalityCountryID = Countries.CountryID      \r\n\t\t  where Gendor=@Gendor";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Gendor", Gendor);

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


        public static DataTable GetPersonByNationalNO(string NationalNO)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string query = "\t\t      SELECT  People.PersonID AS [Person ID], People.NationalNo as[National NO ], People.FirstName as [First Name], People.SecondName as \r\n         [Second Name ], People.ThirdName as [Third Name ], People.LastName as [Last Name ], People.Gendor, \r\n        People.DateOfBirth as [Date Of Birth], Countries.CountryName as [Nationalty], People.Phone, People.Email FROM  \r\n          People INNER JOIN               Countries ON People.NationalityCountryID = Countries.CountryID      \r\n\t\t  where NationalNo=@NationalNO";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNO", NationalNO);

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





        public static DataTable GetPersonByNationalNO1(string NationalNO)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string query = "SELECT People.PersonID, People.NationalNo, People.FirstName, People.SecondName, People.ThirdName, People.LastName, People.Gendor, People.DateOfBirth, Countries.CountryName, People.Phone, People.Email,People.Address\r\nFROM     People INNER JOIN\r\n                  Countries ON People.NationalityCountryID = Countries.CountryID\r\n\t\t\t\t  where NationalNo=@NationalNO;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNO", NationalNO);

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



        public static DataTable GetPersonByCountryName(string CountryName)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string query = "\t\t\t      SELECT  People.PersonID AS [Person ID], People.NationalNo as[National NO ], People.FirstName as [First Name], People.SecondName as \r\n         [Second Name ], People.ThirdName as [Third Name ], People.LastName as [Last Name ], People.Gendor, \r\n        People.DateOfBirth as [Date Of Birth], Countries.CountryName as [Nationalty], People.Phone, People.Email FROM  \r\n          People INNER JOIN               Countries ON People.NationalityCountryID = Countries.CountryID      \r\n\t\t  where Countries.CountryName=@CountryName";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryName", CountryName);

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




        static public bool FindThePersonByID(int PersonID)

        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string query = "SELECT * FROM People WHERE PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
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


        static public int AddNewPerson(string FirstName, string SecondName, string ThirdName, string LastName, DateTime Birthday,
           int CountryID, string NationalNo, string Address, string Email, string Phone, string ImagePath, int Gendor)
        {

            int ContactID = -1;
            string query = "INSERT into People Values \r\n(@NationalNO,@FirstName,@SecondName,@ThirdName,@LastName,@Birthday,@Gendor,@Address,@Phone,@Email,@CountryID,@ImagePath)\r\nSELECT SCOPE_IDENTITY();";



            using (SqlConnection connection = new SqlConnection(Connection.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // إضافة المعاملات مع معالجة القيم الفارغة
                command.Parameters.AddWithValue("@FirstName", FirstName);
                command.Parameters.AddWithValue("@SecondName", SecondName);
                command.Parameters.AddWithValue("@LastName", LastName);
                command.Parameters.AddWithValue("@Birthday", Birthday);
                command.Parameters.AddWithValue("@Gendor", Gendor);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@Phone", Phone);
                command.Parameters.AddWithValue("@CountryID", CountryID);
                command.Parameters.AddWithValue("@NationalNO", NationalNo);

          

                command.Parameters.AddWithValue("@ImagePath",
    string.IsNullOrEmpty(ImagePath) ? (object)DBNull.Value : ImagePath);

                command.Parameters.AddWithValue("@ThirdName",
                    string.IsNullOrEmpty(ThirdName) ? (object)DBNull.Value : ThirdName);

                command.Parameters.AddWithValue("@Email",
                    string.IsNullOrEmpty(Email) ? (object)DBNull.Value : Email);





                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();


                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        ContactID = insertedID;
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


                return ContactID;

            }



        }
            static public DataTable GetAllCountries()
            {

                DataTable dt = new DataTable();
                SqlConnection connection = new SqlConnection(Connection.ConnectionString);
                string quere = "SELECT Countries.CountryName\r\nFROM Countries\r\n";
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


        static public void UpdatePersonInfo (int PersonID,string FirstName, string SecondName, string ThirdName, string LastName, DateTime Birthday,
           int CountryID, string NationalNo, string Address, string Email, string Phone, string ImagePath, int Gendor)
        {
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string query = "update People \r\nset NationalNo=@NationalNo,FirstName=@FirstName,SecondName=@SecondName,ThirdName=@ThirdName,\r\nLastName=@LastName,DateOfBirth=@Birthday,Gendor=@Gendor,Address=@Address,Phone=@Phone,Email=@Email,NationalityCountryID=@CountryID\r\nWHERE PersonID=@PersonID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Birthday", Birthday);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@CountryID", CountryID);
            command.Parameters.AddWithValue("@NationalNO", NationalNo);



            command.Parameters.AddWithValue("@ImagePath",
        string.IsNullOrEmpty(ImagePath) ? (object)DBNull.Value : ImagePath);

            command.Parameters.AddWithValue("@ThirdName",
                string.IsNullOrEmpty(ThirdName) ? (object)DBNull.Value : ThirdName);

            command.Parameters.AddWithValue("@Email",
                string.IsNullOrEmpty(Email) ? (object)DBNull.Value : Email);








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

        static public bool DeletePerosn(int PersonID)
        {

            bool IsDelete=false;
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);

            string query = "Delete from People where PersonID=@PersonID";



            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                  IsDelete = true;
                }
                else
                {
                   IsDelete=false;
                }
            }
            catch (Exception ex)
            {
             //   Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return IsDelete;
        }





    }
}








