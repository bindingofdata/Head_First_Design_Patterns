using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public interface IPizzaIngredientFactory
    {
        public Dough CreateDough();
        public Sauce CreateSauce();
        public Cheese CreateCheese();
        public Veggies[] CreateVeggies();
        public Meat CreateMeat();
        public Seafood CreateSeafood();
    }
}
