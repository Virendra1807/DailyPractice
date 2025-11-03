using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPractice
{
    internal class RestrictMethodToOverride
    {

    }

    public class MainClass
    {
        public virtual void ShowMessage()
        {
            Console.WriteLine("Parent message");
        }
    }

    public class SubClass : MainClass
    {
        public sealed override void ShowMessage() //Sealed means the child of SubClass cant Override this method
        {
            Console.WriteLine("Child message");
        }
    }

    public class GrandSubClass : SubClass
    {
        public new void ShowMessage() //new hides the parent menthod, and if type is parent class then it calls parent method 
        {
            Console.WriteLine("grand child message");
        }
    }


}

