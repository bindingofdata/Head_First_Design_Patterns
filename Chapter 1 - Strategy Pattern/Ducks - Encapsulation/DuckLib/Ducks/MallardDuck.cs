using System;

using DuckLib.Behaviors;

namespace DuckLib.Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck!");
        }
    }
}
