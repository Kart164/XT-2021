using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_2_1.Entites;
using Task2_2_1.Interfaces;

namespace Task2_2_1.Bonuses
{
    public class BonusFactory: IBonusFactory
    {
        public static Bonus CreateBonus(Point position,TypeOfBonus type)
        {
            return type switch
            {
                TypeOfBonus.BulletsWithUranKernel => new BulletsWithUranKernel(position),
                TypeOfBonus.Nitro => new Nitro(position),
                TypeOfBonus.ShiledAndRepair => new ShieldAndRepair(position),
                _ => throw new Exception("this type of bonus doesn't exist"),
            };
        }
    }
}
