using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //overload the "==" operator so it checks if two employee objects are equal by comparing id property
            Employee emp1 = new Employee();
            emp1.firstName = "Bob";
            emp1.lastName = "Smith";
            emp1.id = 1;

            Employee emp2 = new Employee();
            emp2.firstName = "John";
            emp2.lastName = "Comesky";
            emp2.id = 2;
            Console.WriteLine(emp1 == emp2);
            Console.WriteLine(emp1 != emp2);
            Console.ReadLine();
        }
    }
}
