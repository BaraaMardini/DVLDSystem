using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectionName;
namespace UserDataAccessLayer
{
    public class UserData
    {






        static public string GetUserNameByUserID(int UserID)
        {

            string UserName = "";


            SqlConnection connection = new SqlConnection(Connection.ConnectionString);

            string query = "select users.UserName from Users\r\nwhere UserID=@UserID;";
            SqlCommand command = new SqlCommand(query, connection);
            {
                // إضافة المعاملات مع معالجة القيم الفارغة
                command.Parameters.AddWithValue("@UserID", UserID);


            }


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {


                    UserName = (string)reader["UserName"];


                }
                else
                {

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

            return UserName;
        }
    








        static public int GetUserIDByUserNameAndPassword(string UserName, string Password)
        {

            int UserID = -1;
            string query = "\r\n\t\t select Users.UserID from Users\r\n\t\t where Password=@Password and UserName=@UserName;";




            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            {
                // إضافة المعاملات مع معالجة القيم الفارغة
                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@Password", Password);






                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();


                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        UserID = insertedID;
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


                return UserID;

            }
        }



            static public int GetPersonIdByUserNameAndPassword(string UserName, string Password)
        {

            int ID = 0;


            SqlConnection connection = new SqlConnection(Connection.ConnectionString);

            string query = "select PersonID from Users \r\nwhere UserName=@UserName and Password=@Password";
            SqlCommand command = new SqlCommand(query, connection);
            {
                // إضافة المعاملات مع معالجة القيم الفارغة
                command.Parameters.AddWithValue("@UserName",UserName);
                command.Parameters.AddWithValue("@Password", Password);

            }


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    ID = (int)reader["PersonID"];
                

                }
                else
                {
                  
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

            return ID;
        }

        static public bool FindTheUserNameAndPasswordAndActive(string UserName, string Password,int IsActive)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);

            string query = "select * from Users\r\nwhere UserName=@UserName and Password=@Password and IsActive=@IsActive;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);


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















        static public bool FindTheUserNameAndPassword(string UserName,string Password)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);

            string query = "select * from Users\r\nwhere UserName=@UserName and Password=@Password;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);


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



        static public bool FindTheUserName(string UserName)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);

            string query = "select * from Users\r\nwhere UserName=@UserName;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);



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









        static public bool DeleteUser(int UserID)
        {

            bool IsDelete = false;
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);

            string query = "DELETE FROM [dbo].[Users]\r\n      WHERE userID=@UserID;";



            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

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
                    IsDelete = false;
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




        static public void ChangePassword(int PersonID, string Password)
        {


            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string query = "UPDATE [dbo].[Users]\r\n   SET [PersonID] = PersonID\r\n      ,[UserName] =\tUserName\r\n      ,[Password] = @Password\r\n      ,[IsActive] = IsActive\r\n WHERE PersonID=@PersonID;";
            SqlCommand command = new SqlCommand(query, connection);
            {
                // إضافة المعاملات مع معالجة القيم الفارغة
                command.Parameters.AddWithValue("@PersonID", PersonID);
              
                command.Parameters.AddWithValue("@Password", Password);
         


                try
                {
                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                       // Console.WriteLine("Record Updated successfully.");
                    }
                    else
                    {
                       // Console.WriteLine("Record Upadate failed.");
                    }



                }
                catch (Exception ex)
                {
                   // Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();

                }

            }

        }




        public static DataTable GetUserByPersonID1(int PersonID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            //  string query = "SELECT * FROM People WHERE PersonID = @PersonID";
            string query = "\r\nselect * from Users\r\nwhere PersonID=@PersonID;";


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





        static public bool FindThePersonID(int  PersonID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);

            string query = "select * from users \r\nwhere PersonID=@PersonID;";

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
            finally {
                connection.Close();
            }

            return isFound;
        }



        static public void UpdateUserInfo(int PersonID, string UserName, string Password, int IsActive)
        {


            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string query = "UPDATE [dbo].[Users]\r\n   SET [PersonID] = @PersonID\r\n      ,[UserName] = @UserName\r\n      ,[Password] = @Password\r\n      ,[IsActive] = @IsActive\r\n WHERE PersonID=@PersonID;UPDATE [dbo].[Users]\r\n   SET [PersonID] = @PersonID\r\n      ,[UserName] = @UserName\r\n      ,[Password] = @Password\r\n      ,[IsActive] = @IsActive\r\n WHERE PersonID=@PersonID;";
            SqlCommand command = new SqlCommand(query, connection);
            {
                // إضافة المعاملات مع معالجة القيم الفارغة
                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@IsActive", IsActive);



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


        static public DataTable GetAllUsersData()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            string quere = "SELECT Users.UserID as [User ID], Users.PersonID  as [Person ID], People.FirstName+' '+\r\nPeople.SecondName+' ' + People.ThirdName+' ' +People.LastName as [Full Name], Users.UserName as [User Name ], Users.IsActive\r\nFROM     People INNER JOIN\r\n                  Users ON People.PersonID = Users.PersonID";


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




        public static DataTable GetUserByPersonID(int PersonID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            //  string query = "SELECT * FROM People WHERE PersonID = @PersonID";
            string query = "SELECT Users.UserID as [User ID], Users.PersonID  as [Person ID], People.FirstName+' '+\r\nPeople.SecondName+'' + People.ThirdName+'' +People.LastName as [Full Name], Users.UserName as [User Name ], Users.IsActive FROM \r\nPeople INNER JOIN            Users ON People.PersonID = Users.PersonID\r\nwhere users.PersonID=@PersonID;";
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

        public static DataTable GetUserByUserID(int UserID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            //  string query = "SELECT * FROM People WHERE PersonID = @PersonID";
            string query = "SELECT Users.UserID as [User ID], Users.PersonID  as [Person ID], People.FirstName+' '+\r\nPeople.SecondName+'' + People.ThirdName+'' +People.LastName as [Full Name], Users.UserName as [User Name ], Users.IsActive FROM \r\nPeople INNER JOIN            Users ON People.PersonID = Users.PersonID\r\nwhere users.UserID=@UserID;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", UserID);

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


        public static DataTable GetUserByFullName(string FullName)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            //  string query = "SELECT * FROM People WHERE PersonID = @PersonID";
            string query = "SELECT Users.UserID as [User ID], Users.PersonID  as [Person ID], People.FirstName+' '+\r\nPeople.SecondName+'' + People.ThirdName+'' +People.LastName as [Full Name], Users.UserName as [User Name ], Users.IsActive FROM \r\nPeople INNER JOIN            Users ON People.PersonID = Users.PersonID\r\nwhere users.UserID=@UserID;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", FullName);

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







        static public int AddNewUser(int PersonID, string UserName, string Password,int IsActive)
        {

            int UserID = -1;
            string query = "INSERT INTO [dbo].[Users]\r\n           ([PersonID]\r\n           ,[UserName]\r\n           ,[Password]\r\n           ,[IsActive])\r\n     VALUES\r\n          (@PersonID,@UserName,@Password,@IsActive)\r\n\t\t  SELECT SCOPE_IDENTITY();";



            SqlConnection connection = new SqlConnection(Connection.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            {
                // إضافة المعاملات مع معالجة القيم الفارغة
                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@IsActive", IsActive);
         




                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();


                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                      UserID= insertedID;
                    }
                }

                catch (Exception ex)
                {
                    throw new Exception("AddNewUser failed: " + ex.Message, ex);
                }


                finally
                {
                    connection.Close();
                }


                return UserID;

            }







        }





    }
}












//static bool FindContactByID(int ContactID, ref stContact ContactInfo)
//{
//    bool isFound = false;

//    SqlConnection connection = new SqlConnection(connectionString);

//    string query = "SELECT * FROM Contacts WHERE ContactID = @ContactID";

//    SqlCommand command = new SqlCommand(query, connection);

//    command.Parameters.AddWithValue("@ContactID", ContactID);

//    try                                                                           
//    {
//        connection.Open();
//        SqlDataReader reader = command.ExecuteReader();

//        if (reader.Read())
//        {

//            // The record was found
//            isFound = true;
//            ContactInfo.ID = (int)reader["ContactID"];
//            ContactInfo.FirstName = (string)reader["FirstName"];
//            ContactInfo.LastName = (string)reader["LastName"];
//            ContactInfo.Email = (string)reader["Email"];
//            ContactInfo.Phone = (string)reader["Phone"];
//            ContactInfo.Address = (string)reader["Address"];
//            ContactInfo.CountryID = (int)reader["CountryID"];

//        }
//        else
//        {
//            // The record was not found
//            isFound = false;
//        }

//        reader.Close();
//        connection.Close();
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine("Error: " + ex.Message);
//    }


//    return isFound;

//}




