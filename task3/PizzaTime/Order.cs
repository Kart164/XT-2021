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
        public List<AbstractPizza> Pizzas { get; private set; }
        public int Price => Pizzas.Sum(x => x.Cost);
        public Order(List<AbstractPizza> pizzas,Action<string> handler)
        {
            Pizzas = pizzas;
            OrderCooked += handler;
        }
        public void SetID(string id)
        {
            if (id != string.Empty) ID = id;
        }
        
        public void Cook()
        {
            if (Pizzas.Count < 5)
            {
                OrderCooked?.Invoke($"Order {ID} is being prepared");
                Thread.Sleep(new TimeSpan(0, 0, Pizzas.Max(x => x.TimeToCook)));
                OrderCooked?.Invoke($"Order {ID} cooked");
            }
            else
            {
                OrderCooked?.Invoke($"Order {ID} is being prepared");
                Thread.Sleep(new TimeSpan(0, 0, Pizzas.Max(x => x.TimeToCook) + Pizzas.Last().TimeToCook));
                OrderCooked?.Invoke($"Order {ID} cooked");
            }
        }
    }
}
