using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace task3b.GameObjects.Heroes
{
    public class Elf : AbstractHero
    {
        public Elf(int x, int y)
            :base(x, y)
        { }
        public override void Attack()
        {
            Console.WriteLine("Elf's attack!");
        }

        public override void Move(Point step)
        {
            PositionX += step.X;
            PositionY += step.Y;
        }
    }
}