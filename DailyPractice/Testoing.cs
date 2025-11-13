using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPractice
{
    class Testing
    {
        public static int age = 30;

        public Testing(int a)
        {
            age = a;
        }

        public static void Show()
        {
            Console.WriteLine("Age is: " + age);
        }
    }
}
