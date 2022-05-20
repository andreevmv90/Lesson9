using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsProject
{
    public class Handler
    {
        public string Message { get;set; }
        public void DisplayMessage() => Console.WriteLine(Message);
    }
}
