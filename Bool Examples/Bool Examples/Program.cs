using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bool_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(true && false); //console = false (and operator &&)
            Console.WriteLine(true && true); //console = true
            Console.WriteLine(false && false); //console = false

            Console.WriteLine(true && true && true && false); //console = false (all have to be true)
            Console.WriteLine(true && true && true || false); // console = true (with the or || added)

            Console.WriteLine(true || true); //console = true (or operator ||)
            Console.WriteLine(true || false); //console = true (bc one is true = true)
            Console.WriteLine(false || false); //console = false

            Console.WriteLine(true == true); // console = true (equals operator ==)
            Console.WriteLine(true == false); //console = false
            Console.WriteLine(false == false); //console = false

            Console.WriteLine(true != true); //console = false (does not equal operator !=)
            Console.WriteLine(true != false); // console = true 
            Console.WriteLine(false != false); //console = false

            Console.WriteLine(true ^ true); // console = false  (x or operator) 
            Console.WriteLine(true ^ false); // console = true (will be true if one is true but not both)
            Console.WriteLine(false ^ false); // console = false

            Console.ReadLine();
        }
    }
}
