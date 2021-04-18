using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime.PizzaEntities
{
    public abstract class AbstractTopping:AbstractPizza
    {
        protected AbstractPizza basePizza;

        public AbstractTopping(AbstractPizza pizza, string toppingName, int cost):base(pizza.Radius,
            pizza.Name+" with "+toppingName,cost+pizza.Cost,pizza.TimeToCook)
        {
            basePizza = pizza;
        }
    }
}