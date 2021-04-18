using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime.PizzaEntities
{
    public class ExtraCheese:AbstractTopping
    {
        public ExtraCheese(AbstractPizza pizza):base(pizza,"Extra Cheese",69)
        {

        }
    }
}
