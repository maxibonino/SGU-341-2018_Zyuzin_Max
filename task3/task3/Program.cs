using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.Figures;

namespace task3a
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            rec.Draw();

            Ring ring = new Ring(new Circle(new Point(-3.2, 4.5), 20), 14.5);
            ring.Draw();

            Line line = new Line(new Point(3.3, 4.4), new Point(1.8, -4.5));
            line.Draw();

            Round round = new Round(new Point(3.3, 4.4), 13);
            round.Draw();

            Console.WriteLine("*************************************");
            Console.ForegroundColor = ConsoleColor.Cyan;
            IDrawable r = new Round(new Point(3.3, 4.4), 13);
            r.Draw();
            Console.ForegroundColor = ConsoleColor.Gray;

            IDrawable c = new Circle(new Point(2.2, 1.1), 6);
            c.Draw();

            Circle round_in_circle = new Round(new Point(3.3, 4.4), 13);
            round_in_circle.Draw();
        }
    }
}
