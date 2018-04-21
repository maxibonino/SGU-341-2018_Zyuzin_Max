using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Ring
{
    public class Circle
    {
        public Circle(Point center, double radius)
        {
            Center = center;
            R = radius;
        }

        public double R { get; set; }
        public Point Center { get; set; }
    }
}
