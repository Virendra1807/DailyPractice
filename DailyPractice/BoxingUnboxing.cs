using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPractice
{
    internal class BoxingUnboxing
    {

        // Boxing means converting a value type to an object type
        // Unboxing means converting an object type to a value type

        // Class is a blue print of an object

        public void BoxUnbox()
        {
            int num = 123; 
            object obj = num;
            Console.WriteLine("Boxed value: " + obj);
            int unboxedNum = (int)obj;
            Console.WriteLine("Unboxed value: " + unboxedNum);
        }

    }
}
