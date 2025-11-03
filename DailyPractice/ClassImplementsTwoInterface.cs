using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPractice
{
    public class ClassImplementsTwoInterface : ISecondInterface
    {
        public string IName 
        { 
            get
            {
                return "Hello";
            }
            set
            { 
                IName = "";
            }
        }

        void IMainInterface.Display() // Here we cant write override 
        {
            Console.WriteLine("ISecondInterface extends IMainIf so that why IMainif methods are mandatory to declare it in class");
        }
        void ISecondInterface.Display()
        {
            Console.WriteLine("ISecondInterface also has Display() method of its Own so we have to declare it in class");
        }

        void ISecondInterface.show()
        {
            Console.WriteLine("ISecondInterface method show()");
        }
    }
}
