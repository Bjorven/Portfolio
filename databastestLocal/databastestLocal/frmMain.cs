using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databastestLocal
{
    public partial class FrmMain : Form
    {
        //här får ut variablarna till ett objekt vi kan använda i resten av formappen
        private User user;
        // --
        public FrmMain(User user)
        {
            InitializeComponent();
            //--
            this.user = user;
        }


        private void Btn_cashier_Click(object sender, EventArgs e)
        {

        }

        private void Btn_admin_Click(object sender, EventArgs e)
        {

        }

        private void Btn_boss_Click(object sender, EventArgs e)
        {

        }


        private void FrmMain_Load(object sender, EventArgs e)
        {
            // vi kollar vilken roll som User.user har och visar respektiv knapp.
            switch (this.user.RoleId)
            {
                case 2:
                    btn_admin.Hide();
                    btn_boss.Hide();
                    break;
                case 3:
                    btn_cashier.Hide();
                    btn_boss.Hide();
                    break;
                case 5:
                    btn_cashier.Hide();
                    btn_admin.Hide();
                    break;
                default:
                    break;
            }
        }

        private void Btn_logOut_Click(object sender, EventArgs e)
        {
            // vid utloggning ändrar vi värdet på user.checkOut till tidpunktens datum och tid.
            // vi skickar också in user'n till en metod som kommer att räkna ut differansen mellan checkIn och -Out, denna ska sparas till
            // hoursWork.
            DbAcess db = new DbAcess();
            this.Hide();
            user.CheckOut = DateTime.Now;
            db.GetTimestamp(user);
            FrmLogin frmLogin= new FrmLogin();
            frmLogin.Show();
        }
    }
}
