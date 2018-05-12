using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.Figures
{
    public class Ring : IDrawable
    {
        private double ringRadius;
        private Circle greaterCircle;
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

        public void ChangeCircleAndRingRadius(Circle greaterCircle, double ringRadius)
        {
            if (greaterCircle == null || (greaterCircle != null && greaterCircle.R < ringRadius) || ringRadius < 0)
                throw new Exception("Invalid arguments");

            this.greaterCircle = greaterCircle;
            this.ringRadius = ringRadius;
        }

        public override string ToString()
        {
            return $"Center - ({GreaterCircle.Center.X}, {GreaterCircle.Center.Y}), greater radius - {GreaterCircle.R}, lesser radius - {RingRadius}";
        }

        public Circle GreaterCircle
        {
            get => greaterCircle;
            set
            {
                if (value == null && value.R > RingRadius)
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
                if (value < 0 || (GreaterCircle != null && value > GreaterCircle.R) || GreaterCircle == null)
                    throw new Exception("Wrong radius!");

                ringRadius = value;
            }
        }

        public void Draw()
        {
            Console.WriteLine($"Ring: center ({GreaterCircle.Center.X}, {GreaterCircle.Center.Y}) ring radius - {RingRadius}, greater radius - {GreaterCircle.R}");
        }
    }
}
