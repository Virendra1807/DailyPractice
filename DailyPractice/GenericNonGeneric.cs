using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPractice
{
    internal class GenericNonGeneric
    {


        public void Show<T>(T value) => Console.WriteLine("Generic");
        internal void Show(params int[] a) => Console.WriteLine("Int version of params");
        internal void Show(int value) => Console.WriteLine("Int version - Non Generic");

    }
}
