using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_examples
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jesse";
            //string quote = "The man said, \"Hello\", Jesse. \n Hello on a new line. \n \t Hello on a tab.";
            //string fileName = @ "C:\Users\Jesse"; //double backslash for filenames to show up C:\Users\Jesse;

            //bool trueOrfalse = name.Contains("s");
            //trueOrFalse = name.Contains EndsWith("s");

            //int length = name.Length;

            //name = name.ToLower();

            //Console.WriteLine(name);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jesse"); //similar to string for classes and objects


            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
