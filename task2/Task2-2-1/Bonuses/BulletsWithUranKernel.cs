using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_2_1.Entites;

namespace Task2_2_1.Bonuses
{
    public class BulletsWithUranKernel:Bonus
    {
        public BulletsWithUranKernel(Point position) : base(position, TypeOfBonus.BulletsWithUranKernel)
        {
            ActionTime = 15;
        }
        public void AddDamage() { }
    }
}
