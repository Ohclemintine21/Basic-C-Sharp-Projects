using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask user for number and pass to method
            Console.WriteLine("Please enter the first number to do math on: ");
            int UserInput1 = Convert.ToInt32(Console.ReadLine());

            //ask for second number to pass 
            Console.WriteLine("Please enter a second number to do math on: ");
            int UserInput2 = Convert.ToInt32(Console.ReadLine());

            Math math = new Math();

            int result = math.FindMath(UserInput1, UserInput2);
            Console.WriteLine("Result of the FindMath method is: " + result);
            Console.ReadLine();
        }      
    }
}
       