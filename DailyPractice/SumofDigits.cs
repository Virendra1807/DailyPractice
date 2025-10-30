using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPractice
{
    public class SumofDigits
    {
       public int sumofDigits()
        {
            int num = 25062024;
            int sum = 0;
            while (num != 0)
            {
                int digit = num % 10;
                num /= 10;
                sum += digit;
            }

            return sum;
        }

    }
}
