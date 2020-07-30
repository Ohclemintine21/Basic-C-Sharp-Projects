using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method3
{
    class MathMethod
    {
        //first method with two integers with last parameter optional
        public void MathProblem(int num1, int num2 = 5 )
        {
            Console.WriteLine(num1 + num2 );        
        }

    }
}
