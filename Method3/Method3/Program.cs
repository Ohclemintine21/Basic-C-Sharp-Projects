using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method3
{
    class Program
    {
        static void Main(string[] args)
        {
            //pass first integer
            Console.WriteLine("Enter a number to subtract: ");
            int Input1 = Convert.ToInt32(Console.ReadLine());

            //pass second int
            Console.WriteLine("Enter a second number to subtract: ");
            int Input2 = Convert.ToInt32(Console.ReadLine());

            //Instaniate class
            MathMethod mathMethod = new MathMethod();

            //console results
            int result = mathMethod.MathProblem(Input1, Input2);
            Console.WriteLine("Result of MathProblem method is: " + result);
            Console.ReadLine();

        }
    }
}
