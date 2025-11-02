using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPractice.AbstractionMiniPRoject
{
    public abstract class Shape : IShape
    {
        public string Color { get; set; }

        // Abstract method - must be implemented by derived class
        public abstract void Draw();

        // Common functionality (optional)
        public void ShowColor()
        {
            Console.WriteLine($"Shape color is: {Color}");
        }
    }

}
