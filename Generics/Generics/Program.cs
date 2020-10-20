using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
         static void Main()
        {
            //instantiate int as generic parameter
            Employee<int> emp1 = new Employee<int>();
            emp1.Things = new List<int>() { 40, 35, 16, 200, 160 } ; //assign int as property value "Things"
            //instantiate string list as generic parameter
            Employee<string> emp2 = new Employee<string>();
            emp2.Things = new List<string>() { "Cookies", "Cupcakes", "Candy" }; //assign string as property value "Things" 
            //create loop that prints all of Things to console
            foreach (var thing in emp1.Things)
            {
                Console.WriteLine(thing);
            }
            foreach (var thing in emp2.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
       
    }
}
