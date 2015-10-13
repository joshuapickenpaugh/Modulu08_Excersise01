//Joshua Pickenpaugh, IN2017
//October 13th, 2015

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulu08_Excersise01
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            
            Shape shape01 = new Shape();
            total = shape01.Area(4.0, 5.0);
            Console.WriteLine("The area of is: {0}.", total);

            Console.ReadKey();
        }
    }
}
