using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databastestLocal
{
    class Boss:User
    {
        private int userName;
        private int acesslevel = 5;



        public Boss(int uname)
        {
            uname = UserName;
        }

        public int UserName { get; set; }







    }
}
