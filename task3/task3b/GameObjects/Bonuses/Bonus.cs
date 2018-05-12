using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3b.GameObjects.Bonuses
{
    public class Bonus : GameObject
    {
        public Bonus(int x, int y)
        {
            PositionX = x;
            PositionY = y;
        }

        //private char icon;
        public char Icon { get; set; }
        public int LifeTime { get; set; }
    }
}
