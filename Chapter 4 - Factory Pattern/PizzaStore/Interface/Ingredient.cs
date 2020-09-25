using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public abstract class Ingredient
    {
        public string Name { get; set; }
        public string Description { get; set; }

        protected Ingredient(string name, string desciption = null)
        {
            Name = name;
            Description = desciption;
        }

        public override string ToString() => Description ?? Name;
    }
}
