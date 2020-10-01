using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethods
{
    class Math
    {
    //first method
     public int MathOp(int val)
        {
            return val +2;
        }
        //second method
        public decimal MathOp(decimal val)
        {
            return val * 2;
        }
        //third method
        public int MathOp(string val)
        {
            return Int32.Parse(val) * 10;
        }

       
    }
}
