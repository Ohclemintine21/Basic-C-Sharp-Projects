using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //user enters a number
            Console.WriteLine("Please enter a whole number:");
            int UserInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a decimal:");
            decimal UserInt2 = Convert.ToDecimal(Console.ReadLine());
            //instantiate the class
            VoidMethod myVoidMethod = new VoidMethod();
            myVoidMethod.voidMethod(UserInt, out int outInt);
            Console.WriteLine(UserInt + " divided by 2 equals " + outInt + ".");
            myVoidMethod.voidMethod(UserInt2, out decimal outInt2);
            Console.WriteLine(UserInt2 + " times 2 equals " + outInt2 + ".");
            //declare class to be static
            StaticClass.staticDetails();
            Console.ReadLine();
        }
    }
}
