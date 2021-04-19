using PizzaTime.PizzaEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PizzaTime
{
    public class Order
    {
        public event Action<string> OrderCooked;

        public string ID { get; private set; }
        public List<Pizza> Pizzas { get; private set; }
        public int Price => Pizzas.Sum(x => x.Cost);

        public Order(List<Pizza> pizzas,Action<string> handler)
        {
            Pizzas = pizzas;
            OrderCooked += handler;
        }

        public void SetID(string id)
        {
            if (!string.IsNullOrWhiteSpace(id)) ID = id;
        }
        
        public void Cook()
        {
            OrderCooked?.Invoke($"Order {ID} is being prepared");
            if (Pizzas.Count < 5)
            {
                Thread.Sleep(new TimeSpan(0, 0, Pizzas.Max(x => x.TimeToCook)));
            }
            else
            {
                Thread.Sleep(new TimeSpan(0, 0, Pizzas.Max(x => x.TimeToCook) + Pizzas[^1].TimeToCook));
            }
            OrderCooked?.Invoke($"Order {ID} cooked");
        }
    }
}
