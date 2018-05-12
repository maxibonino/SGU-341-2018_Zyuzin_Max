using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3b.GameObjects.Bonuses
{
    // Changing hero's appearance bonus
    public class AppearanceBonus : Bonus
    {
        public AppearanceBonus(int x, int y, AppearanceType type)
            :base(x, y)
        {
            Type = type;
        }

        public enum AppearanceType
        {
            RedCoat,
            BlueGlasses,
            GreenBoots,
            PinkGloves
        }
        public AppearanceType Type { get; set; }
    }
}
