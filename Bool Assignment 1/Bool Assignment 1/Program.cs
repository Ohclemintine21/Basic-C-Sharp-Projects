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
                string answer = "True";
                Console.WriteLine(answer);
            }
            else if (userDUI == "No")
            {
                string answer2 = "False";
                Console.WriteLine(answer2);
            }
            Console.ReadLine(); 

            Console.WriteLine("How many speeding tickets do you have?");
            int numTickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numTickets);
            Console.ReadLine();

            Console.WriteLine("Qualified?");


            string isQualified = Console.ReadLine();

            if (Age >= 15)
            {
                Console.WriteLine(isQualified);
            }
            else if (numTickets <= 1)
            {
                Console.WriteLine(isQualified);
            }
            else if (userDUI = 0) 
            {
                Console.WriteLine(isQualified);
            }
            Console.ReadLine();
        }
    }
}
