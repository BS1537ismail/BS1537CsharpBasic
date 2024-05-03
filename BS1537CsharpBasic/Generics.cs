using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS1537CsharpBasic
{
    internal class Generics<T>
    {
        public string Name { get; set; }
        public T Success { get; set; }
    }
}
