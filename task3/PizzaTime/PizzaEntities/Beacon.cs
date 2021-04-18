using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime.PizzaEntities
{
    public class Beacon: AbstractTopping
    {
        public Beacon(AbstractPizza pizza):base(pizza,"Beacon",129)
        {

        }
    }
}
