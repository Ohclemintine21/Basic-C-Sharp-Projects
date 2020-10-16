using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVoidMethod
{
    class VoidMethod
    {
        //create a void method that outputs an integer
        public void voidMethod(int UserInt, out int outInt)
        {
            //have the method divide the data passed to it by 2 
            outInt = UserInt / 2;
        }
        public void voidMethod(decimal UserInt2, out decimal outInt2)
        {
            outInt2 = UserInt2 * 2;
        }
    }
}
