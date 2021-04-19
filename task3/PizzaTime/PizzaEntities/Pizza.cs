using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime.PizzaEntities
{
    public class Pizza:ICloneable
    {
        public int Radius { get; private set; }
        public string Name { get; protected set; }
        public int Cost { get; protected set; }
        public int TimeToCook { get; protected set; }

        public Pizza(int r, string name, int cost,int time)
        {
            Radius = r;
            Name = name;
            Cost = cost;
            TimeToCook = time;
        }
        public Pizza(Pizza pizza)
        {
            Radius = pizza.Radius;
            Name = pizza.Name;
            Cost = pizza.Cost;
            TimeToCook = pizza.TimeToCook;
        }

        public string PrintInfo()
        {
            return new string($"{Name} ({Radius}cm)");
        }

        public object Clone()
        {
            return new Pizza(this);
        }
    }
}
