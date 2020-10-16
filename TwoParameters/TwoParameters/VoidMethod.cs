using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoParameters
{
    class VoidMethod 
    {
        //create a void method that takes two integers as parameters
        public void TwoIntegers(int int1, int int2)
        {
            //call method in class, specifying the parameters by name
            int int3 = int1 + 70;
            Console.WriteLine("The first number, " + int1 + " , plus 70 equals " + int3 + ".");
            Console.WriteLine("The second number is " + int2 + ".");
        }
    }
}
