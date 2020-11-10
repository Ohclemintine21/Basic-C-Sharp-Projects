using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass2
{
    public abstract class Person
    {
       //create abstract class called person w/ two properties string firstName and string lastName
       public string firstName { get; set; }
       public string lastName { get; set; }
       // method SayName()
       public abstract void SayName();
    }
}

