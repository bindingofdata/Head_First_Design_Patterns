using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new Cheese("Shredded Mozzarella");
        }

        public Dough CreateDough()
        {
            return new Dough("Extra Thick");
        }

        public Meat CreateMeat()
        {
            return new Meat("Pepperoni");
        }

        public Sauce CreateSauce()
        {
            return new Sauce("Plum Tomato");
        }

        public Seafood CreateSeafood()
        {
            return new Seafood("Clams");
        }

        public Veggies[] CreateVeggies()
        {
            return new Veggies[]
            {
                new Veggies("Onions"),
                new Veggies("Garlic"),
                new Veggies("Peppers"),
                new Veggies("Mushrooms"),
            };
        }
    }
}
