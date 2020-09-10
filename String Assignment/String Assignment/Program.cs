using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //concatenate three strings
            string name = "Hello, \"Stephanie\" , how are you?!";

            Console.WriteLine(name);
            Console.ReadLine();

            //concatenate string to Uppercase
            string animal = "The dog grew up quickly!";

            string UcaseAnimal = animal.ToUpper();

            Console.WriteLine($"{UcaseAnimal}");
            Console.ReadLine();

            //Use a Stringbuilder and builds a paragraph of text, one sentence at a time.
            StringBuilder sb = new StringBuilder();

            sb.Append(" My name is Stephanie,");

            sb.Append("\n I started a new chapter of my life by learning to code at the Tech Academy.");

            sb.Append("\n I intend to change my life, become an incredible coder, and gain a great career.");

            sb.Append("\n The belief in myself and the encouragement of others has carried me through this bootcamp.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
