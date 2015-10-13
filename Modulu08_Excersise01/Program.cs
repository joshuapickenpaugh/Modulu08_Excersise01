//Joshua Pickenpaugh, IN2017
//October 13th, 2015

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulu08_Excersise01
{
    public delegate int AddDelagate(int num1, int num2);

    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            int result = 0;

            Shape shape01 = new Shape();
            total = shape01.Area(4.0, 5.0);
            Console.WriteLine("The area of is: {0}.", total);

            AddDelagate ad01 = new AddDelagate(Add);
            result = ad01(1, 2);
            Console.WriteLine("The result of adding 1 and 2, via a delagate, is: {0}", result);
 


            Console.ReadKey();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
