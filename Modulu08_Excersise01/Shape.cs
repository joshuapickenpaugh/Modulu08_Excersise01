using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulu08_Excersise01
{
    class Shape
    {
        private double length;
        private double width;
        
        public Shape()
        {

        }

        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        public double Area()
        {
            return length * width;
        }
        
        public double Area(double l, double w)
        {
            return l * w;
        }
    }
}
