using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_2_1.Entites;

namespace Task2_2_1.Bonuses
{
    public class ShieldAndRepair:Bonus
    {
        public ShieldAndRepair(Point position):base(position,TypeOfBonus.ShiledAndRepair)
        {
            ActionTime = 30;
        }

        public void Repair() { }
        public void Addinvincibility() { }
    }
}
