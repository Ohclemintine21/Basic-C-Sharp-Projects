using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //mutiply user input by 50
            Console.WriteLine("Enter a number: ");
            string multiply = Console.ReadLine();
            int IntegerValue = Convert.ToInt32(multiply);
            int output = IntegerValue * 50;
            Console.WriteLine("Total: {0}", output);
            Console.ReadLine();

            //add user input by 25
            Console.WriteLine("Enter a number: ");
            string add = Console.ReadLine();
            int integerValue = Convert.ToInt32(add);
            int OutPut = integerValue + 25;
            Console.WriteLine("Total: {0}", OutPut);
            Console.ReadLine();

            //divides user input by 12.5
            Console.WriteLine("enter a number: ");
            string divide = Console.ReadLine();
            double integervalue = Convert.ToInt32(divide);
            double Output = integervalue / 12.5;
            Console.WriteLine("total: {0}", Output);
            Console.ReadLine();

            // Takes user input and checks if greater than 50 and prints true or false
            Console.WriteLine("enter a number: ");
            string greaterthan = Console.ReadLine();
            bool trueorfalse = 50 < Convert.ToInt32(greaterthan);
            Console.WriteLine(trueorfalse);
            Console.ReadLine();

            //Takes user input, divides by 7 and prints remainder
            Console.WriteLine("Enter a number: ");
            string remain = Console.ReadLine();
            int remainder =  7 % Convert.ToInt32(remain);
            Console.WriteLine(remainder);
            Console.ReadLine();
 
        }
    }
}
