using PizzaTime.PizzaEntities;
using System;
using System.Collections.Generic;
using System.Threading;

namespace PizzaTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzeria = new Pizzeria();
            pizzeria.OrderUpdated += UpdateHandler;

            var list = new List<AbstractPizza> { new Hawaiian(25), new Pepperoni(30) };
            var list2= new List<AbstractPizza> { new BBQ(35) };
            pizzeria.TakeOrder(new Order(list,UpdateHandler));
            pizzeria.TakeOrder(new Order(list2,UpdateHandler));
            pizzeria.PrepareOrders();
        }
        static void UpdateHandler(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
