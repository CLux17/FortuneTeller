using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings!! and welcome to the Fortune Teller!! \n" +
                "Type your name");
            string name = Console.ReadLine();
            if (name == "your name")
            {
                Console.WriteLine("Ha Ha Ha... very funny...");
                Console.WriteLine("now your name is fool");
                name = "fool";
            }
            else
            {
                Console.WriteLine($"Hello, {name}");
            }
            
        
            Console.WriteLine($"Now {name}, I need you to answer a few more questions...");
            Console.ReadLine();
        }
    }
}
