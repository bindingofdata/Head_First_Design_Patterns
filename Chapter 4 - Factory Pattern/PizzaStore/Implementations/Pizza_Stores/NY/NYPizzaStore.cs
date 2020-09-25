using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(PizzaTypes type)
        {
            return (Pizza)(type switch
            {
                PizzaTypes.Cheese => new CheesePizza(new NYPizzaIngredientFactory()) { Name = "New York Style Cheese Pizza" },
                PizzaTypes.Meat => new MeatPizza(new NYPizzaIngredientFactory()) { Name = "New York Style Pepperoni Pizza" },
                PizzaTypes.Clam => new SeafoodPizza(new NYPizzaIngredientFactory()) { Name = "New York Style Seafood Pizza" },
                PizzaTypes.Veggie => new VeggiePizza(new NYPizzaIngredientFactory()) { Name = "New York Style Veggie Pizza" },
                _ => throw new ArgumentException("Unknown pizza type."),
            });
        }
    }
}
