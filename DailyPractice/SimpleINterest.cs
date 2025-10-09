using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPractice
{
    internal class SimpleINterest
    {

        public static int CalculateSI() 
        { 
            int Principal = 1000; 
            int Rate = 5;
            int Time = 3;
            return (Principal * Rate * Time) / 100;
        }

    }
}
