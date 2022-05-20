using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsProject
{
    public class Counter
    {
        public delegate void CounterHandler();
        public event CounterHandler Notify;

        public void Start()
        {
            for (var i = 0; i < 100; i++)
            {
                if (i == 77) Notify?.Invoke(); 
            }
        }
    }
}
