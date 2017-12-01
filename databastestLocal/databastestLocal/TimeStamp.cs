using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databastestLocal
{
    class TimeStamp
    {
        private int minutes;
        private String showTime;



        public TimeStamp(int min)
        {
            Minutes = min;
        }
        public int Minutes { get; set; }


    }
}
