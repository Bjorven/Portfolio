using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace databastestLocal
{
    public partial class FrmLogin : Form
    {
         

        public FrmLogin()
        {
            InitializeComponent();

        }


        private void FrmLogin_Load(object sender, EventArgs e)
        {



        }



        //LOGIN BUTTON
        private void Btn_Submit_Click(object sender, EventArgs e)
        {



            if (txt_UserName.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                DbAcess db = new DbAcess();
                // här är vår metod för att kolla Db om lösenord och username finns och är rätt.
                // Därefter skickas en fylld instans av klassen User ut.
                User user = db.GetUser(txt_UserName.Text, txt_Password.Text);
                
                



                


                MessageBox.Show("Login Successful!");
                this.Hide();
                // Om allt är rätt skickas vi till nästa fönster, och då skickar vi med den ifyllda instansen
                // av klassen User
                
                // vi  ändrar också värdet på user.checkIn till tidpunktens datum och tid.
                user.CheckIn = DateTime.Now;
                FrmMain Main = new FrmMain(user);
                Main.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Failed!");
                //goggla how to stacktrace print
                //ex.StackTrace
            }
        }












    }
}



//        private void Btn_Submit_Click(object sender, EventArgs e)
//        {

//        }
//    }
//}
