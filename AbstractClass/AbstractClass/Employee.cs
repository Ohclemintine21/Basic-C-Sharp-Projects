using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractClass
{
    class Employee : Person2, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + lastName);
        }  
        public void Quit()
        {
            Console.WriteLine(firstName + " " + lastName + " has quit! ");
            Console.ReadLine();
        }
    }
    internal interface IQuittable
    {
        void Quit();
    }

    class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
