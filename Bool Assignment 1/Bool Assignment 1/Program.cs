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
            //user input age 
            Console.WriteLine("What is your age?");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Age);
            Console.ReadLine();

            //user input number of DUI's
            Console.WriteLine("How you ever had a DUI?");
            var userDUI = Console.ReadLine();

            if (userDUI == "Yes")
            {
                Console.WriteLine("True");
            }
            else if (userDUI != "No")
            {
                Console.WriteLine("False");
            }
            
            Console.ReadLine(); 


            // user input number of speeding tickets
            Console.WriteLine("How many speeding tickets do you have?");
            int numTickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numTickets);
            Console.ReadLine();

             
            // find out if the user is qualified for insurance
            Console.WriteLine("Qualified?");

            bool isQualified = true;
            bool notQualified = false;
           
            if (Age >= 15 && numTickets <= 1 && userDUI != "No")
            {
                Console.WriteLine(isQualified);
            }
            else
            {
                Console.WriteLine(notQualified);
            }
            Console.ReadLine();

        }
    }
}
