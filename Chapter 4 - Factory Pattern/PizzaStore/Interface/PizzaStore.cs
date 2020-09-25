using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(PizzaTypes type)
        {
            Pizza pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        public abstract Pizza CreatePizza(PizzaTypes type);
    }
}
