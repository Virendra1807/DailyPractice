using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPractice
{
    internal class DateDiff
    {

        public void DateDiff1() 
        { 
            String date1 = "01012021";
            String date2 = "01012025";

            DateTime d1 = DateTime.ParseExact(date1, "ddMMyyyy", null);
            DateTime d2 = DateTime.ParseExact(date2, "ddMMyyyy", null);
            TimeSpan ts = d2 - d1;      
            Console.WriteLine("Difference in days: " + ts.TotalDays);

            Console.WriteLine("Difference in years: " + (ts.TotalDays / 365));
            Console.WriteLine("Difference in months: " + (ts.TotalDays / 30));  
            Console.WriteLine("Difference in years: " + ((Convert.ToInt32(date2)%10000) - (Convert.ToInt32(date1)%10000)));
        }

    }
}
