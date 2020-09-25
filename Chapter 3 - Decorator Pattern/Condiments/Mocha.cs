namespace StarbuzzCoffee
{
    internal class Mocha : Beverage
    {
        private readonly Beverage Beverage;

        public Mocha(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override double Cost()
        {
            return Beverage.Size switch
            {
                Sizes.TALL => Beverage.Cost() + .20,
                Sizes.GRANDE => Beverage.Cost() + .30,
                Sizes.VENTI => Beverage.Cost() + .40,
                _ => 0,
            };
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Mocha";
        }
    }
}
