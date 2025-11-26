using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPractice
{
    public interface IMessageService
    {
        string GetMessage();
    }

    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from MessageService!";
        }
    }


   

}
