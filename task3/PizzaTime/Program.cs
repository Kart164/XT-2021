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

            pizzeria.Menu.AddRange(new Pizza[]{new Pizza(25,"Small Pepperoni",375,15),
            new Pizza(30,"Pepperoni",565,20), new Pizza(35,"Big Pepperoni",625,20),
            new Pizza(25,"Small Hawaiian",375,15), new Pizza(30,"Hawaiian",565,20),
            new Pizza(35,"Big Hawaiian",625,20), new Pizza(25,"Small BBQ",425,20),
            new Pizza(30,"BBQ",675,30),new Pizza(35,"Big BBQ",725,35)}); 

            pizzeria.TakeOrder(new Order(pizzas: new List<Pizza> {pizzeria.Menu.GetByName("Small Pepperoni")
                ,pizzeria.Menu.GetByName("Small Hawaiian") },UpdateHandler));
            pizzeria.TakeOrder(new Order(pizzas: new List<Pizza> { pizzeria.Menu.GetByName("BBQ") },UpdateHandler));
            pizzeria.PrepareOrders();
        }
        static void UpdateHandler(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
