﻿using System;
using System.CodeDom;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            //List of integers
            //ask user to divide each number in the list by
            
            List<int> Numbers = new List<int>() {2, 6, 12, 24, 36};

            Console.WriteLine("Pick a number.");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a second number.");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing the two...");
            int numberThree = numberOne / numberTwo;
            Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
            Console.ReadLine();

            int userInput = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Numbers.Count; ++i)
            {
                Numbers[i] /= userInput;
            }

            foreach (var number in Numbers) 
            {
                Console.WriteLine(number);
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please type a whole number.");
            return;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
        finally
        {
            Console.ReadLine();
        }
        Console.WriteLine("Program run by using Try/Catch method");
        Console.ReadLine();
    }
}
