using System;
using System.Collections.Generic;
using System.Linq;

namespace ADO.NET_Task_2_b
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

        public double GetGreaterCircleLength()
        {
            return 2 * Math.PI * GreaterCircle.R;
        }

        public double GetLesserCircleLength()
        {
            return 2 * Math.PI * RingRadius;
        }

        public override string ToString()
        {
            return $"Center - ({GreaterCircle.Center.X}, {GreaterCircle.Center.Y}), greater radius - {GreaterCircle.R}, lesser radius - {RingRadius}";
        }

        public Circle GreaterCircle { get; set; }
        public double RingRadius { get; set; }
    }
}
