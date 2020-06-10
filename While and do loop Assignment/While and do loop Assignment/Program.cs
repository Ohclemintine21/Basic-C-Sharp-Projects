using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_and_do_loop_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the food?");
            string food = Console.ReadLine();
            bool GuessedCorrect = food == pizza;

            while (!GuessedCorrect)
            {
                switch (food)
                {
                   case taco:
                      Console.WriteLine("You guessed taco. Try again.");
                      Console.WriteLine("Guess the food?");
                      food = Console.ReadLine();
                      break;
                    case sushi:
                        Console.WriteLine("You guessed sushi. Try again.");
                        Console.WriteLine("Guess the food?");
                        food = Console.ReadLine();
                        break;
                    case burrito:
                        Console.WriteLine("You guessed burrito. Try again.");
                        Console.WriteLine("Guess the food?");
                        food = Console.ReadLine();
                        break;
                    case pizza:
                        Console.WriteLine("You guessed pizza. That is correct!");
                        GuessedCorrect = true;
                        break;
                    default:
                        Console.WriteLine("You are incorrect.");
                        Console.WriteLine("Guess the food?");
                        food = Console.ReadLine();
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
