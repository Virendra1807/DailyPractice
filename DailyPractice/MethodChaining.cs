using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPractice
{
    class Calculator
    {
        int result = 0;

        public Calculator Add(int n)
        {
            result += n;
            return this;  // returning current object
        }

        public Calculator Multiply(int n)
        {
            result *= n;
            return this;
        }

        public void Show() => Console.WriteLine("Result: " + result);
    }

}
