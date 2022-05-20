using System;

namespace EventsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello.This is a Counter");
            bool flag = false;
            while(!flag)
            {
                Console.WriteLine("Would you like to start : y/n");
                var text = Console.ReadLine();
                switch(text)
                {
                    case "y":
                        flag = true;
                        break;
                    case "n":
                        // Do something
                        break;
                    default:
                        // Do something
                        break;
                }
            }
            var counter = new Counter();

            var handler1 = new Handler() { Message = "Уже 77, давно пора было начать!" };
            var handler2 = new Handler() { Message = "Пора действовать, ведь уже 77" };

            counter.Notify += handler1.DisplayMessage;
            counter.Notify += handler2.DisplayMessage;

            counter.Start();

            Console.ReadKey();
        }
    }
}
