using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3b;

namespace task3b.GameObjects.Heroes
{
    public abstract class AbstractHero : GameObject
    {
        public AbstractHero(int x, int y)
        {
            PositionX = x;
            PositionY = y;
        }
        public string Name { get; set; }
        public int Health { get; set; }

        public abstract void Attack();
        public abstract void Move(Point step);
    }
}
