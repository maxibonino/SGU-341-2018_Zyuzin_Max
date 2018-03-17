using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class Pyramid
    {

        // 4 точки основания
        public const int BaseNumber = 4;

        //private IEnumerable<Point> BaseOfPyramid;
        private Point apex;
        private double height;
        const double EPS = 1e-9;

        int stupidMethod;

        /// <summary>
        /// Введённая высота не должна отличаться от расчётной
        /// </summary>
        /// <param name="BaseOfPyramid">Массив точек основания</param>
        /// <param name="apex">Вершина</param>
        /// <param name="height">Высота</param>
        public Pyramid(IEnumerable<Point> baseOfPyramid, Point apex, double height)
        {
            BaseOfPyramid = baseOfPyramid;
            Apex = apex;
            Height = height;
        }

        public Pyramid(Tuple<IEnumerable<Point>, double> data)
            :this(data.Item1.Take(4), data.Item1.ElementAt(4), data.Item2)
        {
            CheckData(data);
        }

        public IEnumerable<Point> BaseOfPyramid
        {
            get;
            set;
        }

        public Pyramid()
        {
            BaseOfPyramid = (IEnumerable<Point>)(new Point[BaseNumber]);
        }

        #region Exception
        
        private bool IsExistBase(IEnumerable<Point> points)
        {
            double a = Point.GetLength(points.ElementAt(0), points.ElementAt(1));
            double b = Point.GetLength(points.ElementAt(0), points.ElementAt(3));
            double c = Point.GetLength(points.ElementAt(1), points.ElementAt(2));
            double d = Point.GetLength(points.ElementAt(2), points.ElementAt(3));
            return (a < b + c + d) && (b < a + c + d) && (c < b + a + d) && (d < b + c + a);
        }
        #endregion
        private void CheckData(Tuple<IEnumerable<Point>, double> data)
        {
            if (data == null)
                throw new Exception("Invalid data");

            if ((data.Item2 - EPS) <= 0)
                throw new Exception("Invalid height");

            if (data.Item1 == null && data.Item1.Count() != 5)
                throw new Exception("Invalid data!");

            if (!IsExistBase(data.Item1.Take(4)))
                throw new Exception("Wrong pyramid!");
        }
        private double GetAreaBase()
        {
            BaseOfPyramid.ElementAt(3);
            Point veca = BaseOfPyramid.ElementAt(1) - BaseOfPyramid.ElementAt(0);
            Point vecb = BaseOfPyramid.ElementAt(3) - BaseOfPyramid.ElementAt(0);

            double a = Point.GetLength(BaseOfPyramid.ElementAt(0), BaseOfPyramid.ElementAt(0));
            double b = Point.GetLength(BaseOfPyramid.ElementAt(0), BaseOfPyramid.ElementAt(3));

            double cosOfab = Point.DotProduct(veca, vecb) / (a * b);
            double sinOfab = Math.Sqrt(1 - Math.Pow(cosOfab, 2));

            return a * b * sinOfab;
        }

        public Point Apex { get; set; }
        public double Height { get; set; }
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
            //BaseOfPyramid.ElementAt(numOfPoint);
        }

        public void ChangePointsOfBase(Point[] point)
        {
            if (point.Length == 0 || point.Length > 4)
                throw new ArgumentException("Invalid argument");
            BaseOfPyramid = point;
        }
    }
}