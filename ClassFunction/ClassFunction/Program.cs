using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Person myPerson = new Person();
            myPerson.SayName();
            Console.WriteLine("Name: " + myPerson.firstName  + myPerson.lastName);
            Console.ReadLine();
        }    
    }
}
