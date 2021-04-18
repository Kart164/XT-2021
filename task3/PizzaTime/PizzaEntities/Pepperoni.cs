using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime.PizzaEntities
{
    public class Pepperoni:AbstractPizza
    {
        public Pepperoni(int r):base(r,"Pepperoni",0,15)
        {
            Cost=r switch
            {
                35 => 695,
                30 => 565,
                25 => 375,
                _ => throw new ArgumentException("radius should be equals 25 or 30 or 35!", nameof(r))
            };
        }

    }
}
