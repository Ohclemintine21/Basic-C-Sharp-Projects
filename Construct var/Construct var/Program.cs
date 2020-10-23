using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construct_var
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a const variable
            const string theHello = "Welcome to Saturday!";
            //create a variable using the keyword "var"
            var a = 10;
            Console.WriteLine("We just want to say...{0}!", theHello);
            Console.WriteLine("Let's do a high: " + a);
            Console.ReadLine();
        }
        class highTen
        {
            //chain two constructors together
            private int id;
            private string name;
            public highTen() : this(0, "")
            {

            }
            public highTen(int id, string name)
            {
                this.id = id;
                this.name = name;
            }
            public highTen(int id) : this(id, "")
            {

            }
            public highTen(string name) : this(0, name)
            {

            }
            highTen x = new highTen(), y = new highTen(789, "defined"), z = new highTen("xyz");
        }
    }
}
