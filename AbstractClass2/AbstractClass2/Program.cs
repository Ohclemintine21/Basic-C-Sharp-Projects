using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass2
{
    class Program
    {
        static void Main(string[] args, object myObj)
        {
            Employee person = new Employee();
            person.firstName = "Sample";
            person.lastName = "Student";
            person.SayName();

            Console.WriteLine("Name: " + person.firstName + "" + person.lastName);
            Console.ReadLine();
        }
    }
}
