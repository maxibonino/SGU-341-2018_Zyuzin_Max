using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.Figures
{
    class Round : Circle, IDrawable
    {
        public Round(Point center, double radius)
            :base(center, radius)
        {
        }

        void IDrawable.Draw()
        {
            Draw();
        }
        public void Draw()
        {
            Console.WriteLine($"Round: center - {Center.X}, {Center.Y}; radius - {R}");
        }
    }
}
