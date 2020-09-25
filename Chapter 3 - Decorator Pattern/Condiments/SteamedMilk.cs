namespace StarbuzzCoffee
{
    internal class SteamedMilk : Beverage
    {
        private readonly Beverage Beverage;

        public SteamedMilk(Beverage beverage)
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
            return Beverage.GetDescription() + ", Steamed Milk";
        }
    }
}
