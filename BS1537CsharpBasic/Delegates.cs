using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS1537CsharpBasic
{
    internal class Delegates
    {
        public void getArea(double width, double height)
        {
            Console.WriteLine("This is Area : " + width * height);
        }
        public void getPerimeter(double width, double height)
        {
            Console.WriteLine("This is Perimeter : "+ 2*(width+height));
        }

    }
}
