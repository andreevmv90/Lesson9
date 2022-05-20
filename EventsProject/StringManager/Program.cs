using System;
using System.Collections.Generic;

namespace StringProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello.This is a StringSearcher");
            StringSearcher searcher = new StringSearcher();
            searcher.Notify += DisplayMessage;
            bool notify = true;

            var list = new List<string>();
            list.Add(@"I");
            list.Add(@"love");
            list.Add(@"football");

            while (true)
            {
                Console.WriteLine("Write the pattern");
                var pattern = Console.ReadLine();
                if (!string.IsNullOrEmpty(pattern))
                {
                    searcher.Search(list, pattern);
                    if (notify)
                    {
                        Console.WriteLine("Cancel notification? (y/n)");
                        var answer = Console.ReadLine();
                        if (answer == "y")
                        {
                            searcher.Notify -= DisplayMessage;
                            notify = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Restore notification? (y/n)");
                        var answer = Console.ReadLine();
                        if (answer == "y")
                        {
                            searcher.Notify += DisplayMessage;
                            notify = true;
                        }
                    }
                }                
            }
        }

        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
