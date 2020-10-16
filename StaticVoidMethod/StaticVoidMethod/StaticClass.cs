using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVoidMethod
{
    static class StaticClass
    {
        public static string staticStr = "An example of a Static Class";
        //declare class to be static
        public static void staticDetails()
        {
            Console.WriteLine(staticStr);
        }
    }
}
