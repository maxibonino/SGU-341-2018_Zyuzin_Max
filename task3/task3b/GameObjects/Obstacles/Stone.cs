using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3b.GameObjects.Obstacles
{
    public class Stone : GameObject
    {
        public Stone(int x, int y)
        {
            PositionX = x;
            PositionY = y;
        }
    }
}
