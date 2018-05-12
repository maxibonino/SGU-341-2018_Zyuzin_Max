using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3b.GameObjects.Bonuses
{
    public sealed class HealthBonus : Bonus
    {
        public HealthBonus(int x, int y)
            :base(x, y)
        { }
        public int BonusValue { get; set; }
    }
}
