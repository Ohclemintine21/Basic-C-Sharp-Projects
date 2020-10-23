using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person = new Employee();
            person.SayName();
            Console.ReadLine();

            IQuittable myQuit = new Employee();
            myQuit.Quit();
        }
        internal interface IQuittable
        {
            void Quit();
        }
        static void Main1(string[] args)
        {
            Person myObj = new Person();
            Person myObj2 = new Person();
            myObj.Name = "Employee1";
            myObj2.Name = "Employee1";
            Console.WriteLine(myObj.Name == myObj2.Name);
            Console.ReadLine();
        }
        
    }
}
