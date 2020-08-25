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
            Console.WriteLine("Please enter the first number to add: ");
            int UserInput1 = Convert.ToInt32(Console.ReadLine());

            //ask for second number to pass 
            Console.WriteLine("Please enter a second number to add: ");
            int UserInput2 = Convert.ToInt32(Console.ReadLine());

            Math math = new Math();

            int result = math.FindMath(UserInput1, UserInput2);
            Console.WriteLine("Result of the FindMath method is: " + result);
            Console.ReadLine();

            //ask user for a number and pass second method
            Console.WriteLine("Please enter the first number to subtract: ");
            int userInput1 = Convert.ToInt32(Console.ReadLine());

            //ask user for a second number to pass
            Console.WriteLine("Please enter a second number to subtract: ");
            int userInput2 = Convert.ToInt32(Console.ReadLine());

            int result2 = Math.FindMath2(userInput1, userInput2);
            Console.WriteLine("Result of the subtract method is: " + result2);
            Console.ReadLine();

            //ask user for a number to pass third method
            Console.WriteLine("Please enter the first number to multiply: ");
            int UserInput3 = Convert.ToInt32(Console.ReadLine());

            //ask user for second number to multiply
            Console.WriteLine("Please enter a second number to multiply: ");
            int UserInput4 = Convert.ToInt32(Console.ReadLine());

            int result3 = Math.FindMath3(UserInput3, UserInput4);
            Console.WriteLine("Result of multiply method is: " +result3);
            Console.ReadLine();
        }  
    }
}
       