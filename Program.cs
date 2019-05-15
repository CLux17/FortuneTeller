using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings!! and welcome to the Fortune Teller!! \n" +
                "Type your first name");
            string fName = Console.ReadLine();
            Console.WriteLine($"ok {fName}, Now i need your last name.");
            string lName = Console.ReadLine();
            Console.WriteLine($"{lName}, thats a very nice last name");
            string name = (fName +" "+ lName);
            Console.WriteLine($"ok, {name}, how old are you?");
            String age = Console.ReadLine();
            Console.WriteLine($"So your age is {age}? \n" +
                $"You're kinda old... but I digress \n" +
                $"What Month were you born in?");
            
            String monthastext = Console.ReadLine();
            int date = Convert.ToInt32(monthastext);

            Console.WriteLine(monthastext);

            Console.ReadLine();
            
        }
    }
}
