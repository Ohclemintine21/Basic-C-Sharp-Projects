using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bool_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Age);
            Console.ReadLine();


            Console.WriteLine("How you ever had a DUI?");
            string userDUI = Console.ReadLine();

            if (userDUI == "Yes") 
            {
                bool answer = true;
                Console.WriteLine(answer);
            }
            else if (userDUI == "No")
            {
                bool answer2 = false;
                Console.WriteLine(answer2);
            }
            Console.ReadLine(); 

            Console.WriteLine("How many speeding tickets do you have?");
            int numTickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numTickets);
            Console.ReadLine();

            Console.WriteLine("Qualified?");

            bool isQualified = true;
            bool isNotQualified = false;

            if (Age >= 15)
            {
                Console.WriteLine(isQualified);
            }
            else if (numTickets <= 1)
            {
                Console.WriteLine(isQualified);
            }
            else if (userDUI == "No") 
            {
                Console.WriteLine(isQualified);
            }
            else
            {
                Console.WriteLine(isNotQualified);
            }

            Console.ReadLine();
        }
    }
}
