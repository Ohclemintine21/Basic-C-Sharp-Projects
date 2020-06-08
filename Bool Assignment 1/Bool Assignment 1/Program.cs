using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Bool_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput1;
            int intVal;
            
            Console.WriteLine("What is your age?");
            userInput1 = Console.ReadLine();
            //converts to integer type
            intVal = Convert.ToInt32(userInput1);
            Console.WriteLine("{0}", intVal);
            Console.ReadLine();

            // Determine DUI
            Console.WriteLine("Have you ever had a DUI?");

            bool yes = true;
            bool no = false;

            if (no == false)
            {
                Console.WriteLine("false");
            }
            else if (yes == true)
            {
                Console.WriteLine("true");
            }
            Console.ReadLine();

            string userInput2;
            Console.WriteLine("How many speeding tickets do you have?");
            userInput2 = Console.ReadLine();
            Console.WriteLine("{0}", userInput2);
            Console.ReadLine();

            string Qualify;
            Console.WriteLine("Qualified?");
            Qualify = Console.ReadLine();

            if (Qualify.Equals(yes))
            {
                Console.WriteLine("True");
            }
            else if (Qualify.Equals(no))
            {
                Console.WriteLine("false");
            }
            Console.ReadLine();

           
           

        }
    }
}
