using System;

using DuckLib.Ducks;
using DuckLib.Behaviors;

namespace Ducks___Encapsulation
{
    public static class Program
    {
        public static void Main()
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            Duck model = new ModelDuck();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();
        }
    }
}
