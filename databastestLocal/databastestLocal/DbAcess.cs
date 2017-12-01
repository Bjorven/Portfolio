using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.Common;



namespace databastestLocal
{

    class DbAcess
    {
        // Detta läggs här för att slippa upprepa senare i de olika metoderna
        // variabler
        SqlConnection connection;
        SqlCommand command;

        public DbAcess()
        {
            connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=LAPTOP-TU1UMOIC;Initial Catalog=DigitCashier;Integrated Security=True";
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
        } // constructor


        // GetUser är den metod vi använder för att checka username och password mot databas, den returnerar en instans av klassen User med all data som tillhör denna användaren.

        public User GetUser(string txt_UserName, string txt_Password)
        {
            
            command.CommandText = "Select * from Employee where id=@id and passwordPIN=@passwordPIN";
            command.Parameters.AddWithValue("@id", txt_UserName);
            command.Parameters.AddWithValue("@passwordPIN", txt_Password);
            connection.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            connection.Close();

            int count = ds.Tables[0].Rows.Count;

            if (count == 1)
            {
                // här skickar vi ut och tilldelar user's data
                //vi måste göra detta en och en för att se vilken jag har parsat/castat fel.
                User getUser = new User(
                ////UserName 
                Convert.ToString(ds.Tables[0].Rows[0][0].ToString()),
                ////Fname 
                Convert.ToString(ds.Tables[0].Rows[0][1].ToString()),
                ////Sname 
                Convert.ToString(ds.Tables[0].Rows[0][2].ToString()),
                ////dob
                Convert.ToString(ds.Tables[0].Rows[0][3].ToString()),
                ////adress
                Convert.ToString(ds.Tables[0].Rows[0][4].ToString()),
                ////Salary
                Convert.ToInt32(ds.Tables[0].Rows[0][5].ToString()),
                ////postcode
                Convert.ToInt32(ds.Tables[0].Rows[0][6].ToString()),
                ////age
                Convert.ToInt32(ds.Tables[0].Rows[0][7].ToString()),
                ////passwordPin
                Convert.ToInt32(ds.Tables[0].Rows[0][8].ToString()),
                ////reportsTo
                Convert.ToInt32(ds.Tables[0].Rows[0][9].ToString()),
                ////companyId
                Convert.ToString(ds.Tables[0].Rows[0][10].ToString()),
                ////RoleId
                Convert.ToInt32(ds.Tables[0].Rows[0][11].ToString()),
                ////hoursWorked denna funkar inte!!
                Convert.ToInt16(ds.Tables[0].Rows[0][12].ToString()),
                //hiredDate
                Convert.ToDateTime(ds.Tables[0].Rows[0][13].ToString()),
                //lastActiveDateTime
                Convert.ToDateTime(ds.Tables[0].Rows[0][14].ToString()),
                //checkIn
                Convert.ToDateTime(ds.Tables[0].Rows[0][15].ToString()),
                //checkOut
                Convert.ToDateTime(ds.Tables[0].Rows[0][16].ToString())
                );

                return getUser;


            }
            else
            {

                throw new Exception();
            }
        }

        // Detta är vår metod för att spara upp hur lång tid en användare har arbetat (varit inloggad), 
        // denna tid summeras upp till en "total arbetade timmar"-coloumn i Databasen.
        public User GetTimestamp(User user)
        {

            int timeelapsed = (int)user.CheckOut.Subtract(user.CheckIn).TotalMinutes;
            
            user.HoursWorked = user.HoursWorked + timeelapsed;

            command.CommandText = "UPDATE Employee SET checkIn=@checkIn, checkOut=@checkOut, hoursWorked=@hoursWorked where id=@id";
            command.Parameters.AddWithValue("@id", user.UserName);
            command.Parameters.AddWithValue("@checkIn", user.CheckIn);
            command.Parameters.AddWithValue("@checkOut", user.CheckOut);
            command.Parameters.AddWithValue("@hoursWorked", user.HoursWorked);
            //command.Parameters.AddWithValue("@lasActiveDateTime", user.CheckIn);
            connection.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            connection.Close();


            return user;
        }













        // denna är inte klar men ska kunna användas för att kunna hämta information i databasen på användarna

        //public static User GetUsersData(int id)
        //{




        //    command.CommandText = "Select * from User where employeeId=@employeeId";
        //    command.Parameters.AddWithValue("@employeeId", id);
        //    connection.Open();
        //    SqlDataAdapter adapt = new SqlDataAdapter(command);
        //    DataSet ds = new DataSet();
        //    adapt.Fill(ds);
        //    connection.Close();

        //    int count = ds.Tables[0].Rows.Count;

        //    if (count == 1)
        //    {
        //        return ds;
        //    }
        //    else
        //    {
        //        throw new Exception();
        //    }


        //}

















    }
}
