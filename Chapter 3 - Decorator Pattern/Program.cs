using System;

namespace StarbuzzCoffee
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            // straight espresso
            Beverage beverage = new Espresso { Size = Sizes.TALL };
            Console.WriteLine($"{beverage.GetDescription()}: ${beverage.Cost()}");

            beverage = new DarkRoast { Size = Sizes.GRANDE };
            beverage = new Mocha(beverage);
            beverage = new Mocha(beverage);
            beverage = new Whip(beverage);
            Console.WriteLine($"{beverage.GetDescription()}: ${beverage.Cost()}");

            beverage = new HouseBlend { Size = Sizes.VENTI };
            beverage = new Soy(beverage);
            beverage = new Mocha(beverage);
            beverage = new Whip(beverage);
            Console.WriteLine($"{beverage.GetDescription()}: ${beverage.Cost()}");

            Console.ReadLine();
        }
    }
}
