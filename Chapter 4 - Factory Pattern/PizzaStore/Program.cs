using System;

namespace PizzaStore
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyPizzaStore = new NYPizzaStore();
            PizzaStore chicagoPizzaStore = new ChicagoPizzaStore();
            PizzaStore californiaPizzaStore = new CaliforniaPizzaStore();

            Pizza pizza = nyPizzaStore.OrderPizza(PizzaTypes.Cheese);
            Console.WriteLine($"Ethan ordered a {pizza.Name}\n");

            pizza = chicagoPizzaStore.OrderPizza(PizzaTypes.Clam);
            Console.WriteLine($"Joel ordered a {pizza.Name}\n");

            pizza = californiaPizzaStore.OrderPizza(PizzaTypes.Meat);
            Console.WriteLine($"Mike ordered a {pizza.Name}\n");

            Console.ReadLine();
        }
    }
}
