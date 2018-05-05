using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ring
{
    public class Circle
    {
        private double radius;
        public Circle(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }

        public double Radius
        {
            get => radius;
            set
            {
                if (value <= 0)
                    throw new System.Exception("Radius can't be less than zero.");
                radius = value;
            }
        }
        public Point Center { get; set; }
    }
}
