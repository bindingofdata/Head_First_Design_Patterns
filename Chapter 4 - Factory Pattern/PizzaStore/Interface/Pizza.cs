using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace PizzaStore
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public Dough Dough { get; set; }
        public Sauce Sauce { get; set; }
        public List<Veggies> Veggies { get; set; }
        public Cheese Cheese { get; set; }
        public Meat Meat { get; set; }
        public Seafood Seafood { get; set; }

        public abstract void Prepare();

        public virtual void Bake() => Console.WriteLine("Bake for 25 minutes at 350");

        public virtual void Cut() => Console.WriteLine("Cutting the pizza into diagonal slices");

        public virtual void Box() => Console.WriteLine("Place pizza in official PizzaStore box");

        public string GetDescription()
        {
            StringBuilder pizzaDescription = new StringBuilder();
            pizzaDescription.AppendLine($"{Name} with {Dough.Name}, {Sauce.Name}");
            pizzaDescription.AppendLine("Included Toppings:");
            pizzaDescription.AppendLine(Cheese.Name);
            pizzaDescription.AppendLine(Meat.Name);
            pizzaDescription.AppendLine(Seafood.Name);
            for (int i = 0; i < Veggies.Count; i++)
            {
                pizzaDescription.AppendLine(Veggies[i].Name);
            }
            return pizzaDescription.ToString();
        }

        public override string ToString() => Name;
    }
}
