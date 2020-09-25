using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaStore
{
    public class VeggiePizza : Pizza
    {
        IPizzaIngredientFactory IngredientFactory;

        public VeggiePizza(IPizzaIngredientFactory ingredientFactory)
        {
            IngredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = IngredientFactory.CreateDough();
            Sauce = IngredientFactory.CreateSauce();
            Cheese = IngredientFactory.CreateCheese();
            Veggies = IngredientFactory.CreateVeggies().ToList();
        }
    }
}
