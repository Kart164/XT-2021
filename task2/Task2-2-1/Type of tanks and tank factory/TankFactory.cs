using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_2_1.Interfaces;

namespace Task2_2_1.Type_of_tanks_and_tank_factory
{
    public class TankFactory: ITankFactory
    {
        public static Tank CreateTank(TypeOfTank type) 
        {
            return type switch
            {
                TypeOfTank.BalancedTank => new BalancedTank(),
                TypeOfTank.FastTank => new FastTank(),
                TypeOfTank.HeavyTank => new HeavyTank(),
                _ => throw new Exception("this type of tank doesn't exist"),
            };
        }
    }
}
