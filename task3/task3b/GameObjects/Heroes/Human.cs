using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3b.GameObjects.Heroes
{
    public class Human : AbstractHero
    {
        public override void Attack()
        {
            Console.WriteLine("Human's attack!");
        }

        public Human(int x, int y)
            :base(x, y)
        { }

        public override void Move(Point step)
        {
            PositionX += step.X;
            PositionY += step.Y;
        }
    }
}
