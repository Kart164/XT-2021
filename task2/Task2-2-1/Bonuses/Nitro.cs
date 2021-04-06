using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_2_1.Entites;

namespace Task2_2_1.Bonuses
{
    public class Nitro:Bonus
    {
        public Nitro(Point position):base(position, TypeOfBonus.Nitro)
        {
            ActionTime = 20;
        }
        
        public void AddSpeed() { }
    }
}
