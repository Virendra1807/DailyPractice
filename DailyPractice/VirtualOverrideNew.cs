using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPractice
{
    
    public class Parent
    {
        public virtual void Display()
        {
            Console.WriteLine("Parent Display");
        }
    }

    public class Child : Parent
    {
        public override void Display()
        {
            Console.WriteLine("Child Override Display");
        }
    }

    public class AnotherChild : Parent
    {
        public new void Display()
        {
            Console.WriteLine("AnotherChild Hidden Display");
        }
    }





    
}
