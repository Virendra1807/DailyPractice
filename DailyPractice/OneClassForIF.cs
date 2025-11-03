using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPractice
{
    internal class OneClassForIF: IMainInterface
    {
        public void Display()
        {
            Console.WriteLine("Class One Logic");
        }

    }
    internal class TwoClassForIF: IMainInterface
    {
        public void Display()
        {
            Console.WriteLine("Class Two Logic");
        }

    }



}
