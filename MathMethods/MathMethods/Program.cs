using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate first method
            Math mathOne = new Math();
            int result = mathOne.MathOp(3);
            Console.WriteLine(result);

            //instantiate second method
            decimal decimalValue = 6.2M;
            decimal result2 = mathOne.MathOp(decimalValue);
            Console.WriteLine(result2);

            //instantiate third method
            int result3 = mathOne.MathOp("3");
            Console.WriteLine(result3);
            Console.ReadLine();

        }
    }
}
