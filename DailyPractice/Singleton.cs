using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPractice
{
    public class Singleton
    {
        private static Singleton _instance;

        // Private constructor
        private Singleton()
        {
            Console.WriteLine("Private constructor called");
        }

        // Public static method to access instance
        public static Singleton GetInstance()
        {
            Console.WriteLine("GetInstance called");
            if (_instance == null)
                _instance = new Singleton();

            return _instance;
        }


        // Output: Private constructor called (only once)

    }



}
