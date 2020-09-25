using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(PizzaTypes type)
        {
            return (Pizza)(type switch
            {
                PizzaTypes.Cheese => new CheesePizza(new ChicagoPizzaIngredientFactory()) { Name = "Chicago Style Cheese Pizza" },
                PizzaTypes.Meat => new MeatPizza(new ChicagoPizzaIngredientFactory()) { Name = "Chicago Style Pepperoni Pizza" },
                PizzaTypes.Clam => new SeafoodPizza(new ChicagoPizzaIngredientFactory()) { Name = "Chicago Style Seafood Pizza" },
                PizzaTypes.Veggie => new VeggiePizza(new ChicagoPizzaIngredientFactory()) { Name = "Chicago Style Veggie Pizza" },
                _ => throw new ArgumentException("Unknown pizza type."),
            });
        }
    }
}
