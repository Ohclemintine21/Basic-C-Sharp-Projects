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
            string userInput;
            Console.WriteLine("Please enter a number. ");
            userInput = Convert.ToString(Console.ReadLine());

            //log the numebr to text file
            File.WriteAllText(@"C:\Users\ohcle\Documents\Visual Studio 2019\txtFile\log.txt", userInput);
            Console.ReadLine();

            //Prints text file back to user
            Console.WriteLine("You said: " + userInput);
            using(StreamWriter file = new StreamWriter(@"C:\Users\ohcle\Documents\Visual Studio 2019\txtFile\log.txt", true))
            {
                file.WriteLine(userInput);
            }
            Console.ReadLine();
        }
    }
}
