using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportForStudents

{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a simple program
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            Console.WriteLine("What Course are you on?");
            string usercourse = Console.ReadLine();

            
            Console.WriteLine("What Page are you on?");
            int pageNum = Convert.ToInt32(Console.ReadLine());

            int minPage = 1;
            int maxPage = 500;
            int currentPage = int.Parse(pageNum);
            int minRange = Math.Max(minPage, currentPage - 2);
            int maxRange = Math.Min(maxPage, currentPage + 2);
            
            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'.");
            {
                bool noHelp= false;
                bool Help = true;
                if (noHelp == false)
                {
                    Console.WriteLine("");
                }
                else if (Help == true)
                {
                    Console.WriteLine("");
                }
                string userHelp = Console.ReadLine();

                Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
                string userExperience = Console.ReadLine();

                Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
                string userFeedback = Console.ReadLine();

                Console.WriteLine("How many hours did you study?");
                int userPage = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
                Console.ReadLine();
            }
        }
    }
}

