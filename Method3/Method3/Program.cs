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
            //Instaniate class
            MathMethod mathMethod = new MathMethod();

            //pass first integer
            Console.WriteLine("Enter a number to subtract: ");
            int Input1 = Convert.ToInt32( Console.ReadLine());
            

            //pass second int and convert to int
            string Input2 = (Console.ReadLine());
            if (Input2 == " ")
            {
               mathMethod.MathProblem(Input1);
            }
            else
            {
                int input2 = Convert.ToInt32(Input2);
                mathMethod.MathProblem(Input1, input2);
            }
            Console.ReadLine();
            

         

        }
    }
}
