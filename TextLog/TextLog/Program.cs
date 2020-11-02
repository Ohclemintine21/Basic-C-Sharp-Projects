using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextLog
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask user for a number
            string userInput = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please enter a number. ");
            using(StreamWriter file = new StreamWriter(@"C:\Users\ohcle\Documents\Visual Studio 2019\txtFile\log.txt", true))
            {
                file.WriteLine(userInput);
                Console.WriteLine(@"C: \Users\ohcle\Documents\Visual Studio 2019\txtFile\log.txt");
            }
            Console.ReadLine();
        }
    }
}
