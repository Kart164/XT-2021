﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2_1.Type_of_tanks_and_tank_factory
{
    public class BalancedTank:Tank
    {
        public BalancedTank() : base(125, 15, 30, TypeOfTank.FastTank)
        {
        }
    }
}
