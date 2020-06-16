using System;
using System.Collections.Generic;


{
    class Program
    {
        static void Main(string[] args)
        {


        // a one-dimensional array of strings with user input text 
        List<string> intList = new List<string>();
        intList.Add("Hello");
        intList.Add("Welcome back");
        intList.Add("How are you?");

        string[] answer = new string[10];
        for (int i = 0; i < answer.length; i++)
        {
           answer[i] = Console.ReadLine();
        }

        }
    }

