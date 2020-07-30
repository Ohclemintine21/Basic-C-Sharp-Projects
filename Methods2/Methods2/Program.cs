using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            //pass first integer
            Console.WriteLine("Enter a number to multiply: ");
            int Input1 = Convert.ToInt32(Console.ReadLine());

            //pass second integer
            Console.WriteLine("Enter second number to multiply: ");
            int Input2 = Convert.ToInt32(Console.ReadLine());

            //instantiation
            Math2 math2 = new Math2();

            //console result
            int result = math2.MathAdd(Input1, Input2);
            Console.WriteLine("Result of the MathAdd method is: " + result);
            Console.ReadLine();

            //pass first decimal
            Console.WriteLine("Enter a decimal number to subtract: ");
            decimal Input3 = Convert.ToDecimal(Console.ReadLine());

            //pass second decimal
            Console.WriteLine("Enter a second decimal number to subtract: ");
            decimal Input4 = Convert.ToDecimal(Console.ReadLine());

            //instantiate decimal
            Math2 math3 = new Math2();

            //console result
            decimal result2 = Math2.MathAdd(Input3, Input4);
            Console.WriteLine("Result of decimal MathAdd method is: " + result2);
            Console.ReadLine();

            //pass first int
            Console.WriteLine("Enter a number to add: ");
            int num5 = Convert.ToInt32(Console.ReadLine());

            //pass second int
            Console.WriteLine("Enter second number to add: ");
            int num6 = Convert.ToInt32(Console.ReadLine());

            //instantiate int
            Math2 math4 = new Math2();

            //console result
            int result3 = math4.MathAdd(num5, num6);
            Console.WriteLine("Result of integer MathAdd method is: " + result3);
            Console.ReadLine();






        }
    }
}
