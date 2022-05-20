using System;

namespace PingPong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello.This is a Ping Pong");
            Random rnd = new Random();
            int magicNumber = rnd.Next(0, 10);
            if (magicNumber > 2)
            {
                var ping = new Player("Ping");
                var pong = new Player("Pong");

                ping.Notify += pong.SendMessage;
                pong.Notify += ping.SendMessage;

                while (magicNumber > 0)
                {
                    pong.Play(ref magicNumber, ping.Name);
                    ping.Play(ref magicNumber, pong.Name);                 
                }
                
            }
            else
            {
                Console.WriteLine("Sorry. Game is cancelled");
            }
        }
    }
}
