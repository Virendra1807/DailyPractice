using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPractice
{
    public class UseDependencyInjection
    {
        public readonly IMessageService _messageService;
        private readonly INoteService _noteService;

        public UseDependencyInjection(IMessageService messageService, INoteService noteService)
        {
            _messageService = messageService;
            _noteService = noteService;
        }

        public void CallMethodUsingDependencyInjection()
        {
            Console.WriteLine(_messageService.GetMessage());
            Console.WriteLine(_noteService.GetMessage());
        }

    }
}
