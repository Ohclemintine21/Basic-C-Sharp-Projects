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
        //give it two string properties
        public string firstName;
        public string lastName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value;  }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        //give class with void method SayName with no parameters and simply writes persons full name to console
        public void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
