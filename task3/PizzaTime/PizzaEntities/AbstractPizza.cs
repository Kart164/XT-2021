using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime.PizzaEntities
{
    public abstract class AbstractPizza
    {
        public int Radius { get; private set; }
        public string Name { get; protected set; }
        public int Cost { get; protected set; }
        public int TimeToCook { get; protected set; }
        public AbstractPizza(int r, string name, int cost,int time)
        {
            Radius = r;
            Name = name;
            Cost = cost;
            TimeToCook = time;
        }

        public virtual string PrintInfo()
        {
            return new string($"{Name} ({Radius}cm)");
        }
    }
}
