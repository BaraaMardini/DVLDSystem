using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using PeopleDataAccessLayer;
namespace PeopleBusinessLayer1
{
    public class People
    {

       public string FirstName {  get; set; }
       public string ScondName { get; set; }
       public string ThirdName {  get; set; }
       public string LastName { get; set; }

        public string NationalNo {  get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gendor { get; set; }
        public int Phone {  get; set; }
        public string Email {  get; set; }
        public string Address {  get; set; }
        public string Country { get; set; }

        public People()
        {


        }

        private People(int f)
        {

        }


    static public    DataTable GetAllInfoPeople()
        {

            return PeopleData.GetAllPersonData();
        }


        static public DataTable GetPersonByPersonID(int PersonID)
        {
            return PeopleData.GetPersonByPersonID(PersonID);
        }

        static public DataTable GetPersonByFistName(string FirstName)
        {
            return PeopleData.GetPersonByFirstName(FirstName);
        }



        static public DataTable GetPersonBySecondName(string SecondName)
        {
            return PeopleData.GetPersonBySecondName(SecondName);
        }



        static public DataTable GetPersonByThirdName(string ThirdName)
        {
            return PeopleData.GetPersonByThirdName(ThirdName);
        }

        static public DataTable GetPersonByLastName(string LastName)
        {
            return PeopleData.GetPersonByLastName(LastName);
        }

        static public DataTable GetPersonByEmail(string Email)
        {
            return PeopleData.GetPersonByEmail(Email);
        }

        static public DataTable GetPersonByPhone(int Phone)
        {
            return PeopleData.GetPersonByPhone(Phone);
        }


        static public DataTable GetPersonByGendor(string Gendor)
        {
            return PeopleData.GetPersonByGendor(Gendor);
        }


        static public DataTable GetPersonByNationalNO(string NationalNO)
        {
            return PeopleData.GetPersonByNationalNO(NationalNO);
        }


        static public DataTable GetPersonByCountryName(string CountryName)
        {
            return PeopleData.GetPersonByCountryName(CountryName);
        }

        static public bool FindThePersonByPersonID(int PersonID)
        {
            return PeopleData.FindThePersonByID(PersonID);
            
        }
        static public   int AddNewPerson(string FirstName, string SecondName,string ThirdName,string LastName, DateTime Birthday,
          int Country, string NationalNo, string Address,string Email, string Phone, string Image  ,int Gendor )
        {

       return     PeopleData.AddNewPerson(FirstName, SecondName, ThirdName, LastName, Birthday, Country, NationalNo, Address, Email, Phone, Image,Gendor);



        }
 
        static public DataTable GetAllCountries()
        {
            return PeopleData.GetAllCountries();
        }



        static public DataTable GetPersonByPersonID1(int PersonID)
        {
            return PeopleData.GetPersonByPersonID1(PersonID);
        }

        static public DataTable GetPersonBynNationNO1(string NationalNO)
        {
            return PeopleData.GetPersonByNationalNO1(NationalNO);
        }





        static public void UpdatePersonInfo(int PersonID,string FirstName, string SecondName, string ThirdName, string LastName, DateTime Birthday,
         int Country, string NationalNo, string Address, string Email, string Phone, string Image, int Gendor)
        {

           PeopleData.UpdatePersonInfo (PersonID,FirstName, SecondName, ThirdName, LastName, Birthday, Country, NationalNo, Address, Email, Phone, Image, Gendor);



        }

        static public bool DeletePerson(int PersonID)
        {

            return PeopleData.DeletePerosn(PersonID);
         


        }

        public static int GetPersonIDByLicenseID(int LicenseID)
        {
            return PeopleData.GetPersonIDByLicenseID(LicenseID);
        }



    }
}
