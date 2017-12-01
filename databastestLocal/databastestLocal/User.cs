using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databastestLocal
{
   public class User//:Employee
    {

        ///Instansvariabler
        ///

        private string userName;
        private int password;
        private string companyId;
        private string fname;
        private string sname;
        private string adress;
        //private string city;
        private string personnr;
        private int roleId;

        private int hoursWorked;
        private int reportsTo;
        private int age;
        private int postnr;
        private Int64 salary;

        private DateTime checkIn;
        private DateTime checkOut;
        private DateTime lastActivityDate;
        private DateTime hiredDate;

        //
        public User(string uname, string forename, string surname, string persnr, string hadress, Int64 sal, int postcode, int agey, int pword, int ropTo, string compId, int roly, int hw, DateTime hirDate, DateTime lstActivDat, DateTime cekIn, DateTime cekOut)
        {
            UserName = uname;
            Fname = forename;
            Sname = surname;
            Personnr = persnr;
            Adress = hadress;
            Salary = sal;
            Postnr = postcode;
            Age = agey;
            Password = pword;
            ReportsTo = ropTo;
            CompanyId = compId;
            RoleId = roly;
            HoursWorked = hw;
            HiredDate = hirDate;
            LastActivityDate = lstActivDat;
            CheckIn = cekIn;
            CheckOut = cekOut;
        }
        //string forename, string surname, string hadress, int postcode, string hcity, string persnr,  int agey
       // public User(string uname, string forename, string surname, string persnr, string hadress, Int64 sal, int postcode, int agey, int passcode, int ropTo, string compId, string roleIdy, int hw, DateTime hirDate, DateTime lstActivDat, DateTime cekIn, DateTime cekOut)
       // {
       //     uname = UserName;
       //     passcode = Password;
       //     roleIdy = RoleId;
       //     hw = HoursWorked;
       //     ropTo = ReportsTo;
       //     compId = CompanyId;
       //     cekIn = CheckIn;
       //     cekOut = CheckOut;
       //     lstActivDat = LastActivityDate;
       //     hirDate = HiredDate;
       //     forename = Fname;
       //     surname = Sname;
       //     hadress = Adress;
       //     postcode = Postnr;
       //     //hcity = City;
       //     persnr = Personnr;
       //     sal = Salary;
       //     agey = Age;
       //
       //
       // }
        public string UserName { get; set; }
        public int Password { get; set; }
        public int RoleId { get; set; }
        public int HoursWorked { get; set; }
        public int ReportsTo { get; set; }
        public string CompanyId { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public DateTime LastActivityDate { get; set; }
        public DateTime HiredDate { get; set; }
        public string Fname { get; set; }
        public string Sname { get; set; }
        public string Adress { get; set; }
        public int Postnr { get; set; }
        //public string City { get; set; }
        public string Personnr { get; set; }
        public Int64 Salary { get; set; }
        public int Age { get; set; }











    }
}
