namespace StarbuzzCoffee
{
    public abstract class Beverage
    {
        public virtual Sizes Size { get; set; }

        public virtual string GetDescription()
        {
            return "Unknown Beverage";
        }

        public abstract double Cost();
    }
}
