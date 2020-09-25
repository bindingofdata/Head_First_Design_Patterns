using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new Cheese("Reggiano");
        }

        public Dough CreateDough()
        {
            return new Dough("Thin Crust");
        }

        public Meat CreateMeat()
        {
            return new Meat("Sliced Pepperoni");
        }

        public Sauce CreateSauce()
        {
            return new Sauce("Marinara");
        }

        public Seafood CreateSeafood()
        {
            return new Seafood("Fresh Clams");
        }

        public Veggies[] CreateVeggies()
        {
            return new Veggies[]
            {
                new Veggies("Garlic"),
                new Veggies("Onion"),
                new Veggies("Mushrooms"),
                new Veggies("Red Peppers")
            };
        }
    }
}
