using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass2
{
    class Employee : Person
    {
        public new void SayName()
        {
            Console.WriteLine("Name: " + firstName + lastName);
        }
    }
}
