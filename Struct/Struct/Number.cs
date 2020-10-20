using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    public class Number
    {
        public decimal Amount { get; set; }
        public void DecAmount()
        {
            Amount = Decimal.Add(Amount, 4.8m);
        }
    }
}
