using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        // Create an array of strings
        List<string> bookNames = new List<string>() { "Moby Dick", "The Little Prince", "Game of Thrones", "Dune", "Circe" };

        //Ask user for input text
        Console.WriteLine("Enter your favorite book title:");

        //Create a loop that goes through each string in the array, adding user's text to string 
        string UserInput = Console.ReadLine();

        for (int i = 0; i < bookNames.Count; i++)
        {
            Console.WriteLine(bookNames[i] +UserInput);    
        }


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
        List<int> ReadingHours = new List<int>() { 2, 4, 6, 8, 10 };
        List<int> passingTime = new List<int>();

        foreach (int hours in ReadingHours)
        {
            if(hours < 10)
            {
                passingTime.Add(hours);
            }
        }
        Console.WriteLine(passingTime.Count);
        Console.ReadLine();

        //Create a loop where the comparison used to determine whether to continue iterating the loop is a "<=" operator.
        List<int> numberBooks = new List<int>() { 4, 6, 8, 10 };
        List<int> passingNumber = new List<int>();

        foreach(int number in numberBooks)
        {
            if (number <= 10)
            {
                passingNumber.Add(number);
            }
        }
        Console.WriteLine(passingNumber.Count);
        Console.ReadLine();

        //Create a list of strings where each tem is unique
        List<string> speciesWhales = new List<string>() { "Sperm", "Orca", "Beluga", "Blue", "Humpback" };
        

        //Ask user to input text to search for in the list
        Console.WriteLine("Select your favorite whale from the list: ");
        string userInput = Console.ReadLine();

        //Create a loop that iterates through the loop and then displays the index of the array that contains matching text on the screen
        for (int i = 0; i < speciesWhales.Count; i++)
        {
            if (userInput == speciesWhales[i])
            {
                Console.WriteLine("Match found at index " + i);
            }
        }
        

        //list of strings that has two identical strings in list
        List<string> pets = new List<string>() { "dog", "dog", "cat", "bird", "fish" };

        //foreach loop that evaluates each item in list and displays all items
        foreach (string pet in pets)
        {
            Console.WriteLine("List of common pets: " +pet);
        }
        Console.ReadLine();
    }

}
    

