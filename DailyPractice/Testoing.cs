using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPractice
{
    class ParentClass
    {
        public static int age = 30;
        short? isActive = null;

        public ParentClass(ParentClass obj)
        {
            Console.WriteLine("Parent", obj);
        }

        //public static void Show()
        //{
        //    Console.WriteLine("Age is: " + age);
        //}
    }

    class ChildTesting : ParentClass
    {
        public ChildTesting(ChildTesting obj): base(obj)
        {
          
        }
    }
    class ChildTesting2 : ParentClass
    {
        public ChildTesting2(ChildTesting2 obj): base(obj)
        {
          
        }
    }



}
