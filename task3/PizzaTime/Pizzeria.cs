using PizzaTime.PizzaEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PizzaTime
{
    public class Pizzeria
    {
        public event Action<string> OrderUpdated;

        private char _charOfOrderId;
        private int _orderCounter;

        public PizzaCollection Menu { get; private set; }
        public List<Order> AcceptedOrders { get; private set; }
        public List<Order> OrdersOnGive { get; private set; }

        public Pizzeria()
        {
            _charOfOrderId = 'A';
            _orderCounter = 0;
            AcceptedOrders = new List<Order>();
            OrdersOnGive = new List<Order>();
            Menu = new PizzaCollection();
        }

        public void TakeOrder(Order order)
        {
            order.SetID(new string(_charOfOrderId+_orderCounter.ToString()));
            _orderCounter++;
            OrderUpdated?.Invoke($"order {order.ID} accepted");
            AcceptedOrders.Add(order);
        }
        public void PrepareOrders()
        {
            foreach (var item in AcceptedOrders)
            {
                var i=new Thread(item.Cook);
                i.Start();
                OrdersOnGive.Add(item);
            }
            OrdersOnGive.AddRange(AcceptedOrders);
            AcceptedOrders.Clear();
        }
        public void GiveOrders()
        {
            foreach (var item in OrdersOnGive)
            {
                OrderUpdated?.Invoke($"order {item.ID} given");
            }
            OrdersOnGive.Clear();
        }
    }
}
