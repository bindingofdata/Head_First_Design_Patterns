using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class MeatPizza : Pizza
    {
        IPizzaIngredientFactory IngredientFactory;

        public MeatPizza(IPizzaIngredientFactory ingredientFactory)
        {
            IngredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = IngredientFactory.CreateDough();
            Sauce = IngredientFactory.CreateSauce();
            Cheese = IngredientFactory.CreateCheese();
            Meat = IngredientFactory.CreateMeat();
        }
    }
}
