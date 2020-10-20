using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            //object data type Number and assign amount
            Number dec1 = new Number();
            dec1.Amount = 4.8m;
            //print amount to console
            Console.WriteLine(dec1.Amount);
            Console.ReadLine();
        }
    }
}
