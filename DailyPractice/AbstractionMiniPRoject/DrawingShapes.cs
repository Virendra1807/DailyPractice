using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPractice.AbstractionMiniPRoject
{
    class DrawingShapes
    {
    }

    public class Circle : Shape
    {
        public int Radius { get; set; }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a Circle with radius {Radius}");
        }
    }

    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a Rectangle of {Width}x{Height}");
        }
    }

}
