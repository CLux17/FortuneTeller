using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //Greeting
            Console.WriteLine("Greetings!! and welcome to the Fortune Teller!! \n" +
                "\n" +
            //Ask For First Name
                "Type your first name");
            string fName = Console.ReadLine();

            //ASk for last name
            Console.WriteLine($"Ok {fName}, Now I need your last name.");
            string lName = Console.ReadLine();

            //Comment to confirm name and combine first and last
            Console.WriteLine($"{lName}, thats a very nice last name");
            string name = (fName +" "+ lName);

            //Aquire age
            Console.WriteLine($"Alright {name}, using numerals, how old are you?");
            int nAge = Convert.ToInt32(Console.ReadLine());

            //Comment on age,  and aquire month
            Console.WriteLine($"So your age is {nAge}? \n" +
                $"Wow, you're kinda old... but I digress, \n" +
                $"\n" +
                $"Using numerals, what month were you born in?\n" +
                $"(Hint, January = 1, Febreuary = 2, etc. etc.");
            int nMonth = Convert.ToInt32(Console.ReadLine());

            //aquire favorite color
            Console.WriteLine("$Ok, {name}, Now i need your favorite ROYGBIV color?\n" +
                "Don't know what ROYGBIV is? type,\"help\"");
            string tColor = Console.ReadLine();

            //provide assistance for user if not know ROYGBIV
            while (tColor.ToLower() == "help")
            {
                Console.WriteLine("ROYGBIV is the primary colors, Red Orange, Yellow, Green, Blue, Indigo, and Violet.");
                tColor = Console.ReadLine();
            }

            //Aquire # of siblings
            Console.WriteLine($"Final question {name}, How many siblings do you have?");
            int nSiblings = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Fantastic, I have all the info I need to read your fortune!\n");
            Console.ReadLine();
            Console.WriteLine("\n" +
                "\n" +
                "Push Y and enter if you dare to tempt the fates and know their plans...\n" +
                "\n" +
                "Push N and enter if you dare not tempt the fates...");
            string fate = Console.ReadLine();

           


            if (fate.ToLower() == "y")
            {

                //Solution for Age
                int age = 1;
                if (nAge%2 == 0)
                    {
                        int age = 24;
                    }
                else
                    {
                        int age = 17;
                    }

                //Solution for Month
                int income = 0;
                if (nMonth <= 4)
                    {
                        int income = 3;
                    }
                else if (nMonth >= 5 || nMonth <= 8)
                    {
                        int income = 257843;
                    }
                else if (nMonth >= 9)
                    {
                        float income = 45283;
                    }    
                
                //Solution for color choice
                string color = "Unknown";
                switch (tColor.ToLower())
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

                //Siblings
                int siblings = 1;


                //Answer
                Console.WriteLine($"{name}, You will retire in {age} years, \n" +
                    $"your bank account will at that time have {income} Dollars in it, \n" +
                    $"You will have a vacation home in {siblings}, \n" +
                    $"And your main mode of transportation will be by {color}");

            }

            else if (fate.ToLower() == "n")

                {
                    Console.WriteLine("You have chosen well. Best to not tempt the fates");
                }


            Console.WriteLine("");
            Console.WriteLine($"Thank you {name} for participating in this reading.\n" +
                $"\n" +
                $"Goodbye.");
            Console.ReadLine();
            
            
            
        }
    }
}
