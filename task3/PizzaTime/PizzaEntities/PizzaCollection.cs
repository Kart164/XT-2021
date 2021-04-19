using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime.PizzaEntities
{
    public class PizzaCollection
    {
        public List<Pizza> Pizzas { get; private set; }

        public PizzaCollection()
        {
            Pizzas = new List<Pizza>();
        }

        public void Add(Pizza pizza)
        {
            Pizzas.Add(pizza);
        }
        public void AddRange(Pizza[] pizzas)
        {
            Pizzas.AddRange(pizzas);
        }
        public void Remove(string pizzaName)
        {
            Pizzas.RemoveAll(x => x.Name == pizzaName);
        }
        public Pizza GetByName(string pizzaName)
        {
            return Pizzas.FirstOrDefault(x => x.Name == pizzaName);
        }
    }
}
