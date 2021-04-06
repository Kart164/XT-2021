using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2_1.Type_of_tanks_and_tank_factory
{
    public class FastTank:Tank
    {
        public FastTank():base(50,30,15,TypeOfTank.FastTank)
        {
        }
    }
}
