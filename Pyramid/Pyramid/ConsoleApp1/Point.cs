using System;

namespace ConsoleApp1
{
    #region TypePoint
    public struct Point
    {
        public Point(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public static Point operator -(Point a, Point b)
        {
            return new Point { X = b.X - a.X, Y = b.Y - a.Y, Z = b.Z - a.Z };
        }
        public static double GetLength(Point a, Point b)
        {
            Point vector = b - a;
            return Math.Sqrt(Math.Pow(vector.X, 2) + Math.Pow(vector.Y, 2) + Math.Pow(vector.Z, 2));
        }

        public static double DotProduct(Point a, Point b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        }
    }
    #endregion
}
