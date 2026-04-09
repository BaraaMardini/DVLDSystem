using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDataAccessLayer;
namespace UserBusinessLayer
{
    public class  User
    {


        static public string GetUserNameByUserID(int UserID)
        {
            return UserData.GetUserNameByUserID(UserID);
        }

        static public int GetPersonIdByUserNameAndPassword(string UserName, string Password)
        {
           return   UserData.GetPersonIdByUserNameAndPassword(UserName, Password);  
        }


        static  public bool FindThePersonID(int PersonID)
        {
            return UserData.FindThePersonID(PersonID);
        }
        static public DataTable GetAllUsersData()
        {

            return UserData.GetAllUsersData();
        }

        static public int AddNewUser(int PersonID, string UserName, string Password, int IsActive)
        {
            return UserData.AddNewUser(PersonID, UserName, Password, IsActive);
        }


        static public void UpdateUserInfo(int PersonID, string UserName, string Password, int IsActive)
        {
            UserData.UpdateUserInfo(PersonID,UserName,Password,IsActive);
        }

        public static DataTable GetUserByPersonID1(int PersonID)
        {
            return UserData.GetUserByPersonID1(PersonID);
        }
        public static void ChangePassword(int PersonID,string Passwrod)
        {
            UserData.ChangePassword(PersonID,Passwrod);
        }


        static public bool DeleteUser(int UserID)
        {
            return UserData.DeleteUser(UserID); 
        }


        static public bool FindTheUserName(string UserName)
        {
            return UserData.FindTheUserName(UserName);
        }

        static public bool FindTheUserNameAndPassword(string UserName, string Password)
        {
            return UserData.FindTheUserNameAndPassword(UserName, Password); 
        }

        static public bool FindTheUserNameAndPasswordAndActive(string UserName, string Password, int IsActive)
        {
            return UserData.FindTheUserNameAndPasswordAndActive(UserName, Password,IsActive);    
        }
        static public int GetUserIDByUserNameAndPassword(string UserName,string Password)
        {
          return    UserData.GetUserIDByUserNameAndPassword(UserName,Password);
        }



    }
}
