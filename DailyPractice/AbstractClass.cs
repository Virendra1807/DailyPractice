using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPractice
{
    abstract class AbstractClass
    {
        protected AbstractClass() { }
        public abstract string Name { get; }

        public abstract void MandatoryMethod();
        public void ConcreteMethod()
        {
            Console.WriteLine("Concrete Method From Abstract Class");
        }
        
    }
}
