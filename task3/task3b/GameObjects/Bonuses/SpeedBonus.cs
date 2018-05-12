using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3b.GameObjects.Bonuses
{
    public class SpeedBonus : Bonus
    {
        public SpeedBonus(int x, int y)
            :base(x, y)
        { }
        public int BonusValue { get; set; }
    }
}
