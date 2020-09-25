namespace StarbuzzCoffee
{
    class DarkRoast : Beverage
    {
        public override string GetDescription()
        {
            return "Dark Roast";
        }

        public override double Cost()
        {
            return Size switch
            {
                Sizes.TALL => .99,
                Sizes.GRANDE => 1.09,
                Sizes.VENTI => 1.19,
                _ => 0,
            };
        }
    }
}
