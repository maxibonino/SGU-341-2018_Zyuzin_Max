using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Ring
{
    public class Ring
    {
        public Ring(Circle greaterCircle, double ringRadius)
        {
            GreaterCircle = greaterCircle;
            RingRadius = ringRadius;
        }

        public double GetArea()
        {
            return Math.PI * (GreaterCircle.R * GreaterCircle.R - RingRadius * RingRadius);
        }

        public double 

        public Circle GreaterCircle { get; set; }
        public double RingRadius { get; set; }
    }
}
