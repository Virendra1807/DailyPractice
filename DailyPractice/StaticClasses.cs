using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPractice
{
    public static class StaticClasses
    {

        static StaticClasses()
        {
            // Static constructor to initialize any static data or perform actions that need to be done once.
            Console.WriteLine("StaticClasses static constructor called.");
        }
        public static void DisplayMessage()
        {
            Console.WriteLine("Hello from a static class!");
        }

    }
}
