using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Employee<T> //generic type parameter
    {
        public List<T> Things { get; set; } //add property "Things" be a generic list
    }
}
