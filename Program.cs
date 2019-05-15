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

            Console.WriteLine($"ok {name},using numerals, how old are you?");
            String tAge = Console.ReadLine();
            int age = Convert.ToInt32(tAge);

            Console.WriteLine($"So your age is {age}? \n" +
                $"Wow, you're kinda old... but I digress, \n" +
                $"What Month were you born in?");
            String monthAsText = Console.ReadLine();
            int nMonth = Convert.ToInt32(monthAsText);

            


            Console.WriteLine(monthAsText);

            Console.ReadLine();
            
        }
    }
}
