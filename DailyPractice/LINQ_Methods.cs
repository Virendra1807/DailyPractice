using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPractice
{
    internal class LINQ_Methods
    {
        public LINQ_Methods() { }

        static int[] numbers = { 1,2,3,4,5,6,7,8,9};

        public static void LinqExample()
        {
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList<int>();
            Console.WriteLine("Even Numbers:");


            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }

            var result = numbers.Where(n => n % 2 == 0).Select(n => n);
            foreach (var num in result)
            {
                Console.WriteLine(num);
            }
        }

    }
}
