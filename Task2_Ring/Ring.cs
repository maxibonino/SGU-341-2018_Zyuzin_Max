using System;

namespace Ring
{
   public class Ring
    {
        private double ringRadius;
        private Circle greaterCircle;

        public Ring(Circle greaterCircle, double ringRadius)
        {
            GreaterCircle = greaterCircle;
            RingRadius = ringRadius;
        }

        public Circle GreaterCircle
        {
            get => greaterCircle;
            set
            {
                if (value == null && value.Radius > RingRadius)
                    throw new Exception("Wrong circle!");
                else
                    greaterCircle = value;
            }
        }
        public double RingRadius
        {
            get => ringRadius;
            set
            {
                if (value < 0 || value > GreaterCircle.Radius || GreaterCircle == null)
                    throw new Exception("Wrong radius!");

                ringRadius = value;
            }
        }

        public double GetArea()
        {
            return Math.PI * (GreaterCircle.Radius * GreaterCircle.Radius - RingRadius * RingRadius);
        }

        public double GetGreaterCircleLength()
        {
            return 2 * Math.PI * GreaterCircle.Radius;
        }

        public double GetLesserCircleLength()
        {
            return 2 * Math.PI * RingRadius;
        }

        public override string ToString()
        {
            return $"Center - ({GreaterCircle.Center.X}, {GreaterCircle.Center.Y}), greater radius - {GreaterCircle.Radius}, lesser radius - {RingRadius}";
        }
    }
}