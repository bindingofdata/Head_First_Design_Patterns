namespace StarbuzzCoffee
{
    internal class Whip : Beverage
    {
        private readonly Beverage Beverage;

        public Whip(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override double Cost()
        {
            return Beverage.Size switch
            {
                Sizes.TALL => Beverage.Cost() + .10,
                Sizes.GRANDE => Beverage.Cost() + .15,
                Sizes.VENTI => Beverage.Cost() + .20,
                _ => 0,
            };
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Whipped Cream";
        }
    }
}
