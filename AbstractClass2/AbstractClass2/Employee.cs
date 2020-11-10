using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractClass2
{
    public class Employee : Person
    {
        //implement the SayName() method inside employee class
        public override void SayName()
        {
            Console.WriteLine($"Name: {firstName} {lastName}");
        }
    }
}         
