using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.Figures
{
    public class Circle
    {
        private double radius;
        public Circle(Point center, double radius)
        {
            Center = center;
            R = radius;
        }

        public double R
        {
            get => radius;
            set
            {
                if (value <= 0)
                    throw new System.Exception("Radius can't be less than zero.");
            }
        }
        public Point Center { get; set; }
    }
}
