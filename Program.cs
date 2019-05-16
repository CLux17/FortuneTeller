using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Greetings!! and welcome to the Fortune Teller!! \n" +
                "\n" +
           
                "Type your first name");
            string fName = Console.ReadLine();

            
            Console.WriteLine("");
            Console.WriteLine($"Ok {fName}, Now I need your last name.");
            string lName = Console.ReadLine();

            
            Console.WriteLine("");
            Console.WriteLine($"{lName}, thats a very nice last name");
            string name = (fName +" "+ lName);

            
            Console.WriteLine("");
            Console.WriteLine($"Alright {name}, using numerals, how old are you?");
            int nAge = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("");
            Console.WriteLine($"So your age is {nAge}? \n" +
                $"Wow, you're kinda old... but I digress, \n" +
                $"\n" +
                $"Using numerals, what month were you born in?\n" +
                $"(Hint, January = 1, Febreuary = 2, etc. etc.");
            int nMonth = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("");
            Console.WriteLine($"Ok, {name}, Now i need your favorite ROYGBIV color?\n" +
                "Don't know what ROYGBIV is? type,\"help\"");
            string tColor = Console.ReadLine().ToLower();

            
            while (tColor == "help")
            {
                Console.WriteLine("ROYGBIV is the primary colors, Red Orange, Yellow, Green, Blue, Indigo, and Violet.");
                tColor = Console.ReadLine();
            }

            
            Console.WriteLine("");
            Console.WriteLine($"Final question {name}, How many siblings do you have?");
            int nSiblings = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("");
            Console.WriteLine("Fantastic, I have all the info I need to read your fortune!\n");
            Console.WriteLine("\n" +
                "\n" +

                "Push Y and enter if you dare to tempt the fates and know their plans...\n" +
                "\n" +
                "Push N and enter if you dare not tempt the fates...");
            string fate = Console.ReadLine();
            Console.WriteLine("\n" +
                "\n" +
                "\n" +
                "\n");

            
            int age = 0;
            float income = 0.0f;
            string siblings = "unknown1";
            string color = "Unknown2";

            if (fate.ToLower() == "y")
            {

                
                
                if (nAge%2 == 0)
                    {
                        age = 652;
                    }
                else
                    {
                        age = 17;
                    }

               
                
                if (nMonth <= 4)
                    {
                        income = 3.52f;
                    }
                else if (nMonth >= 5 || nMonth <= 8)
                    {
                        income = 257843;
                    }
                else if (nMonth >= 9)
                    {
                        income = 45283;
                    }    
                
                
                
                switch (tColor)
                {
                    case "red":
                            color = "a giant peach";
                        break;
                    case "orange":
                            color = "the Dukes of Hazard's Car";
                        break;
                    case "yellow":
                            color = "a yellow submarine";
                        break;
                    case "green":
                            color = "a Space X Rocket";
                        break;
                    case "blue":
                            color = "a Flying Car";
                        break;
                    case "indigo":
                            color = "a Pogo Stick";
                        break;
                    case "violet":
                            color = "a Rolls-Royce";
                        break;
                    default:
                        color = "unknown";
                        break;
                }

                

                if (nSiblings >= 3)
                    {
                        siblings = "BFE, probably to get some peace and quiet";
                    }

                else if (nSiblings < 0)
                    {
                    siblings = "a nice beach front property with a white picket fence in Hell";
                    }

                else
                {
                    switch (nSiblings)
                    {
                        case 0:
                            siblings = "the gulag, in old Soviet Russia. In Soviet Russia, Big brother is your sibling.";
                            break;
                        case 1:
                            siblings = "Berlin, Germany";
                            break;
                        case 2:
                            siblings = "Reykjavick, Iceland";
                            break;
                    }
                }


                        
                        Console.WriteLine($"{name}, You will retire in {age} years, \n" +
                    $"your bank account at that time will have {income} dollars in it, \n" +
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
