namespace StarbuzzCoffee
{
    internal class HouseBlend : Beverage
    {
        public override string GetDescription()
        {
            return "House Blend";
        }

        public override double Cost()
        {
            return Size switch
            {
                Sizes.TALL => .89,
                Sizes.GRANDE => .95,
                Sizes.VENTI => .99,
                _ => 0,
            };
        }
    }
}
