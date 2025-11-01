using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPractice
{
    internal class Encapsulation
    {
        // Private field - hidden from outside
        private int age;

        // Public property - provides controlled access
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0)
                    age = value;
                else
                    Console.WriteLine("Age must be positive!");
            }
        }
    }
}
