using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPractice
{
    public class SingletoDesingPattern
    {
        private SingletoDesingPattern() { }

        private static SingletoDesingPattern _instance;
        private static readonly object _lock = new object();

        public static SingletoDesingPattern GetInstance()
        {
            if (_instance == null)
            {
                // Double-checked locking to ensure thread safety - Multi thread can make instance at same time so use lock
                // But lock is costly, it might slow down performance, so first check without lock
                lock (_lock) // one thread can access this block at a time
                {
                    if (_instance == null)
                    {
                        _instance = new SingletoDesingPattern();
                    }
                }
            }
            return _instance;
        }

        public void ShowMsg()
        {
            Console.WriteLine("This is Singleton Design Pattern Example");
        }


    }
}
