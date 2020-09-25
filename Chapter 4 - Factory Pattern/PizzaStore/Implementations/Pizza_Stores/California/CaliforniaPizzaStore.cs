using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class CaliforniaPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(PizzaTypes type)
        {
            return (Pizza)(type switch
            {
                PizzaTypes.Cheese => new CheesePizza(new CaliforniaPizzaIngredientFactory()) { Name = "California Style Cheese Pizza" },
                PizzaTypes.Meat => new MeatPizza(new CaliforniaPizzaIngredientFactory()) { Name = "California Style Pepperoni Pizza" },
                PizzaTypes.Clam => new SeafoodPizza(new CaliforniaPizzaIngredientFactory()) { Name = "California Style Seafood Pizza" },
                PizzaTypes.Veggie => new VeggiePizza(new CaliforniaPizzaIngredientFactory()) { Name = "California Style Veggie Pizza" },
                _ => throw new ArgumentException("Unknown pizza type."),
            });
        }
    }
}
