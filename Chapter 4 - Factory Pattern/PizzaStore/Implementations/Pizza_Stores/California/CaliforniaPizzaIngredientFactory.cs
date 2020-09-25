using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class CaliforniaPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new Cheese("Shredded Cheese Blend");
        }

        public Dough CreateDough()
        {
            return new Dough("Hand Tossed");
        }

        public Meat CreateMeat()
        {
            return new Meat("Pepperoni");
        }

        public Sauce CreateSauce()
        {
            return new Sauce("Robust Marinara");
        }

        public Seafood CreateSeafood()
        {
            return new Seafood("Clams");
        }

        public Veggies[] CreateVeggies()
        {
            return new Veggies[]
            {
                new Veggies("Avocado"),
                new Veggies("Garlic"),
                new Veggies("Sun Dried Tomato"),
                new Veggies("Olives"),
                new Veggies("Mushrooms"),
            };
        }
    }
}
