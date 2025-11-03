using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPractice
{
    internal class ExtendsAbstractClass : AbstractClass, IMainInterface
    {
        public override void MandatoryMethod()
        {
            Console.WriteLine("Mandatory Method from AbstractClass and mandatory to give Override keyword");
        }

        void IMainInterface.Display()
        {
            Console.WriteLine("Mandatory Method from i/f and mandatory to give keyword");
        }

        public override string Name
        {
            get { return "Extended abstract member"; }
        }
    }
}
