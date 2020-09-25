namespace StarbuzzCoffee
{
    internal class Decaf : Beverage
    {
        public override string GetDescription()
        {
            return "Decaf";
        }

        public override double Cost()
        {
            return Size switch
            {
                Sizes.TALL => 1.05,
                Sizes.GRANDE => 1.25,
                Sizes.VENTI => 1.45,
                _ => 0,
            };
        }
    }
}
