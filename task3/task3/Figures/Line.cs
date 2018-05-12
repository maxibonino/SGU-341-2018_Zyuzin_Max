using System;

namespace task3.Figures
{
    public class Line : IDrawable
    {
        private Point _start;
        private Point _end;

        private void CheckStartPoint(Point start)
        {
            if (start == null)
                throw new ArgumentNullException();
        }

        private void CheckEndPoint(Point end)
        {
            if (end == null)
                throw new ArgumentNullException();
        }
        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }

        public Point Start
        {
            get => _start;
            set
            {
                CheckStartPoint(value);
                _start = value;
            }
        }
        public Point End
        {
            get => _end;
            set
            {
                CheckEndPoint(value);
                _end = value;
            }
        }

        public void Draw()
        {
            Console.WriteLine($"Line: start - ({Start.X}, {Start.Y}), end - ({End.X}, {End.Y})");
        }
    }
}
