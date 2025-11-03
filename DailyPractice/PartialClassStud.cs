using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPractice
{
    internal partial class PartialClassStud
    {
        public partial void DisplayDetails()
        {
            Console.WriteLine($"Roll No: {RollNo}, Name: {Name}");
        }

    }
}
