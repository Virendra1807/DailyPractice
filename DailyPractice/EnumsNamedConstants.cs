using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPractice
{
    internal class EnumsNamedConstants
    {

        enum OrderStatus
        {
            Pending = 1,
            Shipped = 2,
            Delivered = 3,
            Cancelled = 4

        }
        public static void ShowEnum()
        {
            OrderStatus st = OrderStatus.Shipped;
            int stText = (int)OrderStatus.Shipped;
            Console.WriteLine("Order Status: "+ st +" : "+ stText);
        }

    }
}
