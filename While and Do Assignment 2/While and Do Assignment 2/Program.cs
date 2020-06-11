using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_and_Do_Assignment_2
{
    class Program
    {
        static void Main(string[] args, string whale)
        {
            Console.WriteLine("Guess the animal?");
            string animal = Console.ReadLine();
            bool GuessedRight = animal == "whale";

            do
            {
                switch (animal)
                {
                    case "bird":
                        Console.WriteLine("You guessed bird. Try again.");
                        Console.WriteLine("Guess the animal?");
                        animal = Console.ReadLine();
                        break;
                    case "cat":
                        Console.WriteLine("You guessed cat. Try again.");
                        Console.WriteLine("Guess the animal?");
                        animal = Console.ReadLine();
                        break;
                    case "dog":
                        Console.WriteLine("You guessed dog. Try again.");
                        Console.WriteLine("Guess the animal?");
                        animal = Console.ReadLine();
                        break;
                    case "whale":
                        Console.WriteLine("You guessed Whale. That is correct!");
                        GuessedRight = true;
                        break;
                    default:
                        Console.WriteLine("You are incorrect.");
                        Console.WriteLine("Guess the animal?");
                        animal = Console.ReadLine();
                        break;
                }
            }
            while (!GuessedRight);
            Console.ReadLine();
        }
    }
}
