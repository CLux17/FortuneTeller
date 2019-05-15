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
                $"Using numerals, what month were you born in?\n" +
                $"(Hint, January = 1, Febreuary = 2, etc. etc.");
            String monthAsText = Console.ReadLine();
            int nMonth = Convert.ToInt32(monthAsText);

            Console.WriteLine("$Ok, {name}, Now i need your favorite ROYGBIV color?\n" +
                "Don't know what ROYGBIV is? type, \"help\"");
            string tColor = Console.ReadLine();

            while (tColor == "help")
            {
                Console.WriteLine("ROYGBIV is the primary colors, Red Orange, Yellow, Green, Blue, Indigo, and Violet.");
                tColor = Console.ReadLine();
            }

            Console.WriteLine($"Final question {name}, How many siblings do you have?");
            int siblings = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fantastic, I have all the info I need to read your fortune,")




            string color = "Unknown";
            switch (tColor)
            {
                case "red":
                    color = "Maserati";
                    break;
                case "orange":
                    color = "stallion";
                    break;
                case "yellow":
                    color = "chariot";
                    break;
                case "green":
                    color = "taxi";
                    break;
                case "blue":
                    color = "rickshaw";
                    break;
                case "indigo":
                    color = "motor scooter";
                    break;
                case "violet":
                    color = "flying saucer";
                    break;
            }



            Console.ReadLine();
            
            
            
        }
    }
}
