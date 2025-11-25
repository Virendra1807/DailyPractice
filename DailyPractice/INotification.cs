using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPractice
{
    public interface INotification
    {
        void send();
    }

    public class SMS : INotification
    {
        public void send()
        {
            Console.WriteLine("Sending SMS notification");
        }
    }
    public class Email : INotification
    {
        public void send()
        {
            Console.WriteLine("Sending Email notification");
        }
    }


    public class NotificationFactory
    {
        public static INotification CreateNotification(string type)
        {
            if (type.Equals("SMS", StringComparison.OrdinalIgnoreCase))
            {
                return new SMS();
            }
            else if (type.Equals("Email", StringComparison.OrdinalIgnoreCase))
            {
                return new Email();
            }
            
            return null;
        }
    }
}
