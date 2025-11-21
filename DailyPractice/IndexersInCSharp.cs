using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPractice
{
    internal class IndexersInCSharp
    {
        private int[] arr = new int[5];

        public int this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }

        public void DisplayArray()
        {
            Console.WriteLine("Array elements: " + string.Join(", ", arr));
        }

    }
}
