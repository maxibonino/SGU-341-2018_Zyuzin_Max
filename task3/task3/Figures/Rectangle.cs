using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace task3.Figures
{
    public class Rectangle : IDrawable
    {
        private Point[] _points;

        private void CheckConstraints(Point[] points)
        {
            if (points == null || points.Length != 4)
                throw new Exception("Wrong array points");
        }

        public Rectangle(Point[] points)
        {
            CheckConstraints(points);
            
            Points = points;
        }

        public Rectangle()
        {
            Points = new Point[] {new Point(0, 0), new Point(0, 0), new Point(0, 0), new Point(0, 0) };
        }

        public Point[] Points
        {
            get => _points;
            set
            {
                CheckConstraints(value);
                _points = value;
            }
        }

        public void Draw()
        {
            Console.WriteLine($"Rectangle - {Points[0]}, {Points[1]}, {Points[2]}, {Points[3]}");
        }
    }
}
