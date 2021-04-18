using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime.PizzaEntities
{
    public class BBQ:AbstractPizza
    {
        public BBQ(int r) : base(r, "BBQ", 0, 30)
        {
            Cost = r switch
            {
                35 => 745,
                30 => 625,
                25 => 425,
                _ => throw new ArgumentException("radius should be equals 25 or 30 or 35!", nameof(r))
            };
        }
    }
}
