using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPractice
{
    internal partial class PartialClassStud
    {
        public int RollNo { get; set; }
        public string Name { get; set; }

        // Declaration only
        public partial void DisplayDetails();

        public void Show()
        {
            DisplayDetails(); // Will call only if implemented
        }
    }
}
