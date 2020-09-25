namespace StarbuzzCoffee
{
    internal class Espresso : Beverage
    {
        public override string GetDescription()
        {
            return "Espresso";
        }

        public override double Cost()
        {
            return Size switch
            {
                Sizes.TALL => 1.99,
                Sizes.GRANDE => 2.49,
                Sizes.VENTI => 2.99,
                _ => 0,
            };
        }
    }
}
