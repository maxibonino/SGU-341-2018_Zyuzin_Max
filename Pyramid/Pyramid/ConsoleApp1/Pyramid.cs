using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Pyramid
    {

        // 4 точки основания
        public const int BaseNumber = 4;

        private Point[] baseOfPyramid;
        private Point apex;
        private double height;

        int stupidMethod;

        /// <summary>
        /// Введённая высота не должна отличаться от расчётной
        /// </summary>
        /// <param name="baseOfPyramid">Массив точек основания</param>
        /// <param name="apex">Вершина</param>
        /// <param name="height">Высота</param>
        public Pyramid(Point[] baseOfPyramid, Point apex, double height)
        {
            this.BaseOfPyramid = baseOfPyramid;
            this.apex = apex;
            this.height = height;
        }

        public Point[] BaseOfPyramid
        {
            get { return baseOfPyramid; }
            set
            {
                if (!IsExistBase(value))
                {
                    throw new ArgumentException("Invalid base");
                }                
            }
        }

        public Pyramid()
        {
            this.baseOfPyramid = new Point[BaseNumber];
        }

        #region Exception
        private bool IsExistBase(Point[] points)
        {
            double a = Point.GetLength(points[0], points[1]);
            double b = Point.GetLength(points[0], points[3]);
            double c = Point.GetLength(points[1], points[2]);
            double d = Point.GetLength(points[2], points[3]);
            return (a < b + c + d) && (b < a + c + d) && (c < b + a + d) && (d < b + c + a);
        }
        #endregion

        private double GetAreaBase()
        {
            Point veca = baseOfPyramid[1] - baseOfPyramid[0];
            Point vecb = baseOfPyramid[3] - baseOfPyramid[0];

            double a = Point.GetLength(baseOfPyramid[0], baseOfPyramid[1]);
            double b = Point.GetLength(baseOfPyramid[0], baseOfPyramid[3]);

            double cosOfab = Point.DotProduct(veca, vecb) / (a * b);
            double sinOfab = Math.Sqrt(1 - Math.Pow(cosOfab, 2));

            return a * b * sinOfab;
        }

        public double AreaBase
        {
            get
            {
                return GetAreaBase();
            }
        }

        private double GetVolume()
        {
            return height * GetAreaBase() / 3;
        }

        public double Volume
        {
            get
            {
                return GetVolume();
            }
        }

        public void ChangeApex(Point apex)
        {
            this.apex = apex;

        }

        public void ChangePointOfBase(Point point, int numOfPoint)
        {
            stupidMethod = numOfPoint;
            if (numOfPoint < 0 || numOfPoint > 4)
                throw new ArgumentException("Invalid argument");
            baseOfPyramid[numOfPoint] = point;
            
        }

        public void ChangePointsOfBase(Point[] point)
        {
            if (point.Length == 0 || point.Length > 4)
                throw new ArgumentException("Invalid argument");
            baseOfPyramid = point;
        }
    }
}