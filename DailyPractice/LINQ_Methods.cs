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

        static int[] numbers = { 1,8,3,4,7,6,29,10,9};

        public static void LinqExample()
        {
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList<int>();
            //Console.WriteLine("Even Numbers:");

            //foreach (var num in evenNumbers)
            //{
            //    Console.WriteLine(num);
            //}

            //var result = numbers.Where(n => n % 2 == 0).Select(n => n);
            //foreach (var num in result)
            //{
            //    Console.WriteLine(num);
            //}

            var LargestThreeNumbers = numbers.OrderByDescending(n => n).Take(3).ToList<int>();
            var SmallestThreeNumbers = numbers.OrderByDescending(n => n).Skip(numbers.Count() - 3).ToList<int>();





        }

    }
}
