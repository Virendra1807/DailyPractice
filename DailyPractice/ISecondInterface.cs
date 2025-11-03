using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPractice
{
    public interface ISecondInterface : IMainInterface
    {
        public string IName {  get; set; }
        public void show();
        public void Display();
    }
}
