using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Package Express. Please follow instructions below.");
            Console.ReadLine();

            Console.WriteLine("Please enter the package weight:");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.Have a good day");
                System.Environment.Exit(1);
            }
            Console.ReadLine();

            Console.WriteLine("Please enter the package width:");
            int widthPackage = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Please enter the package height:");
            int heightPackage = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Please enter the package length:");
            int lengthPackage = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();


            if (widthPackage >= 50 || heightPackage >= 50 || lengthPackage >= 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express");
                System.Environment.Exit(1);
            }
            Console.ReadLine();

            int Dimensions = (widthPackage * lengthPackage * heightPackage * packageWeight);
            float quote = Dimensions / 100;
            Console.WriteLine(Dimensions);
            
            Console.WriteLine("Your estimated total for shipping this package is: ");
            Console.WriteLine(quote);

            Console.WriteLine("Thank you.");
            Console.ReadLine();
        }
    }
}
