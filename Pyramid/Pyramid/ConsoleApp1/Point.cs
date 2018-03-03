﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    #region TypePoint
    public struct Point
    {
        public double x, y, z;
        public Point(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Point operator -(Point a, Point b)
        {
            return new Point { x = b.x - a.x, y = b.y - a.y, z = b.z - a.z };
        }
        public static double GetLength(Point a, Point b)
        {
            Point vector = b - a;
            return Math.Sqrt(Math.Pow(vector.x, 2) + Math.Pow(vector.y, 2) + Math.Pow(vector.z, 2));
        }

        public static double DotProduct(Point a, Point b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z;
        }
    }
    #endregion
}
