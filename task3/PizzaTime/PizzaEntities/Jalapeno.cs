using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime.PizzaEntities
{
    public class Jalapeno:AbstractTopping
    {
        public Jalapeno(AbstractPizza pizza):base(pizza,"Jalapeno",49)
        {

        }
    }
}
