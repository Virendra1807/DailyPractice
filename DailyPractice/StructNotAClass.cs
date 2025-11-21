using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPractice
{
    struct StructNotAClass
    {

        public int X;
        public int Y;
        public StructNotAClass(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void DisplayCoordinates()
        {
            Console.WriteLine($"Coordinates: ({X}, {Y})");
        }


    }
}
