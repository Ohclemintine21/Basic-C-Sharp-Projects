using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFunction
{
    //create a class called Person
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        //give class with void method SayName with no parameters and simply writes persons full name to console

        public void SayName()
        {
           Console.WriteLine("Name: " +  firstName + lastName);
        }    
    }
}
