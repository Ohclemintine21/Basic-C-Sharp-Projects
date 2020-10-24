using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                try
                {
                    //ask user for their age
                    Console.WriteLine("How old are you?");
                    int userAge;
                    userAge = Convert.ToInt32(Console.ReadLine());
                    //display year user was born
                    var date01 = DateTime.Now.Year;
                    var userYear = (date01 - userAge);

                    

                    if (userAge == 0)
                        throw new System.wrongNumber();
                    if (userAge < 0)
                        throw new System.wrongNumber();
                    Console.WriteLine("You were born in: " + userYear);
                    Console.ReadLine();
                }
                //Exceptions using try/catch
                catch (wrongNumber)
                {
                    //general exception 
                    Console.WriteLine("Please enter actual age.");
                    Console.ReadLine();
                }
                catch (Exception)
                {
                    //display error message if the user enters zero or negative numbers
                    Console.WriteLine("Please enter a real number no zeros and no negatives. ");
                    Console.ReadLine();
                }
                finally
                {
                    Console.WriteLine("How old are you?");
                    int userAge;
                    userAge = Convert.ToInt32(Console.ReadLine());

                    var date01 = DateTime.Now.Year;
                    var userYear = (date01 - userAge);

                    if (userAge == 0)
                        throw new System.wrongNumber();

                    if (userAge < 0)
                        throw new System.wrongNumber();

                    //Console.WriteLine(userYear);

                    Console.WriteLine("You were born in: " + userYear);
                    Console.ReadLine();
                }
            }
        }
    }
}
