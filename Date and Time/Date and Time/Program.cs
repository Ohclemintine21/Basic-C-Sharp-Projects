using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_and_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks user for a number 1-9
            double userInput;
            Console.WriteLine("Please eneter a numebr from 1-9.");
            userInput = double.Parse(Console.ReadLine());
            Console.WriteLine("You said, " + userInput);
            Console.ReadLine();

            //Prints current date and time to the console
            Console.WriteLine("The current date and time is: ");
            var date01 = DateTime.Now;
            Console.WriteLine(date01);
            Console.ReadLine();

            //Prints user input from previous step as x hours added to real time
            Console.WriteLine("The time plus your choice is: ");
            var resultTime = date01.AddHours(userInput);
            Console.WriteLine(resultTime);
            Console.ReadLine();
        }
    }
}
