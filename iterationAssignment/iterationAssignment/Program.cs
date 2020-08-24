using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        // Create an array of strings
        string[] bookNames = { "Moby Dick", "The Little Prince", "Game of Thrones", "Dune", "Circe" };

        //Ask user for input text
        Console.WriteLine("Enter your favorite book title:");

        //Create a loop that goes through each string in the array, adding user's text to string 
        string UserInput = Console.ReadLine();

        for (int i = 0; i < bookNames.Length; i++)
        {
            Console.WriteLine(bookNames[i] + UserInput);
        }
        Console.ReadLine();

        //Create a loop that prints off each string in the array on separate line
        foreach (string bookName in bookNames)
        {
            Console.WriteLine(bookName);
        }
        Console.ReadLine();

        //Create an infinite loop and fix so it will execute
        for (int i = 0; i < 5; i++)
        {
            if (i == 5)
            {
                break;
            }
            Console.WriteLine(i);

        }
        //Create a loop where the comparison used to determine whether to continue iterrating the loop is a "<"
        {
            var ReadHours = 5;

            for (int i = 0; i < ReadHours; i++)
                Console.WriteLine(ReadHours);
        }
        Console.ReadLine();

        //Create a loop where the comparison used to determine whether to continue iterating the loop is a "<=" operator.
        {
            int numberBooks = 5;

            for (int i = 0; i <= numberBooks; i++)
                Console.WriteLine(i);
        }
        Console.ReadLine();

        //Create a list of strings where each tem is unique
        var speciesWhales = new List<string>() { "Sperm", "Orca", "Beluga", "Blue", "Humpback" };

        //Ask user to input text to search for in the list
        Console.WriteLine("Select your favorite whale from the list: ");
        var userInput = Console.ReadLine();

        //Create a loop that iterates through the loop and then displays the index of the array that contains matching text on the screen
        foreach (string whale in speciesWhales)
        {
            if (userInput == whale )
            {
                Console.WriteLine("Match found at index " +userInput.Length);
                break;
            }
            //add code that tells user input is not in list
            else
            {
                Console.WriteLine("Sorry, that input is not in the list of whales. ");
            }

            //list of strings that has two identical strings in list
            List<string> pets = new List<string>() { "dog", "dog", "cat", "bird", "fish" };

            //Ask the user to select text to search for in the list
            string UserInput2 = Console.ReadLine();
            Console.WriteLine("Select a pet to search for in the list: " + UserInput2);

            //for loop that evaluates each item in list and displays all items
            for (int i = 0; i < pets.Count; i++)
            {
                if (UserInput2 == pets[i])
                {
                    Console.WriteLine(pets.Count);
                    break;
                }
                //add code to loop that tells user they put in text that isn't in list
                else
                {
                    Console.WriteLine("Sorry that input is not in the list. ");
                }
            }
            Console.ReadLine();

            //Create a list of strings with two identical strings in the list
            List<string> Cars = new List<string>() { "Volvo", "Toyota", "Honda", "Ford", "Honda" };

            //Create a foreach loop that evaluates each item in the list and displays a message showing the string & whether or not it has already appeared in the list
            foreach (string car in Cars)
            {
                Console.WriteLine("This car has appeared in list already:" + car);
            }
            Console.ReadLine();
        }
    }
}
    

