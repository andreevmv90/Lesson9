using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    public class Player
    {
        public delegate void MessageHandler(string message);
        public event MessageHandler Notify;

        public string Name { get; }

         public Player(string name)
        {
            Name = name;
        }

        public void Play(ref int index, string otherPlayer)
        {
            string msg = string.Empty;
            if (index > 1) msg = $"{Name} получил {otherPlayer}";
            else if (index == 1) msg = $"{Name} промахнулся! Победил {otherPlayer}";
            index--;

            Notify?.Invoke(msg);
        }

        public void SendMessage(string message)
        {
            Console.WriteLine(message);          
        }
    }
}
