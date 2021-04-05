using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2_1.Entites
{
    public abstract class Bonus:GameObject
    {
        public TypeOfBonus TypeOfBonus { get; private set; }
        public int ActionTime { get; protected set; }//seconds

        public Bonus(Point position,TypeOfBonus type)
        {
            Type = TypeOfGameObj.Bonus;
            Position = position;
            TypeOfBonus = type;
        }
    }
    public enum TypeOfBonus
    {
        ShiledAndRepair,
        BulletsWithUranKernel,
        Nitro
    }
}
