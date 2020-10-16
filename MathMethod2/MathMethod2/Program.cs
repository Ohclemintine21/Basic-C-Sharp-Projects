using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethod2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            //ask user to input two numbers one at a time
            Console.WriteLine("Please enter a whole number: ");
            int userInt1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second whole number (optional): ");

            //instaniate the class
            Math2 mathInstance = new Math2();
            int userInt2;
            int result;
            if(int.TryParse(Console.ReadLine(), out userInt2))
            {
                result = mathInstance.MyMathAdd(userInt1, userInt2);
            }
            else
            {
                result = mathInstance.MyMathAdd(userInt1);
            }
            Console.WriteLine(userInt1 + " plus " + userInt2 + " plus 75 equals " + result + ".");
            Console.ReadLine();
        }
    }
}
