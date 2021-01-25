using System;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello! Welcome to the number analyzer!");
            Console.Write("I'm glad you're here. Can you please tell me your name?: ");
            string userName = Console.ReadLine();
            bool realInteger = false;
            string continueInput ;
            int userInput = 0;
            
            do
            {
                Console.Write($"{userName}, please enter a number from 1 - 100: ");
                string input = Console.ReadLine();
                realInteger = int.TryParse(input, out userInput);
                int evenOrOdd = (userInput % 2);
                Console.WriteLine();

                if ((userInput < 1) || (userInput > 100) || (realInteger == false))
                {
                    Console.WriteLine($"Oops! Sorry, {userName}, your entry of {input} is not valid. Please enter a number from 1 -100.");

                }              
                else if (evenOrOdd != 0 && userInput <= 60)
                {
                    Console.WriteLine($"{userName}, your number is odd.");
                    Console.WriteLine();
                }
                else if (evenOrOdd == 0 && userInput >= 2 && userInput <= 25)
                {
                    Console.WriteLine($"{userName}, your number is even and less than 25.");
                    Console.WriteLine();
                }
                else if (evenOrOdd == 0 && userInput > 25 && userInput <= 60)
                {
                    Console.WriteLine($"{userName}, your number is even.");
                    Console.WriteLine();
                }
                else if (evenOrOdd == 0 && userInput > 60)
                {
                    Console.WriteLine($"{userName}, you entered {userInput} and it is even.");
                    Console.WriteLine();
                }
                else if (evenOrOdd != 0 && userInput > 60)
                {
                    Console.WriteLine($"{userName}, your number is {userInput} and it is odd.");
                    Console.WriteLine();
                }

                Console.Write("Would you like to continue? (y/n):");
                continueInput = Console.ReadLine();

            }

            while (continueInput == "y");
            Console.WriteLine("Thanks for visiting! Have a great day.");
        }
    }
}


