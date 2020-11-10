using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass2
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate an Employee Object
            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";

            // call the SayName() method on the object
            employee.SayName();
            Console.ReadLine();
        }
    }
}
