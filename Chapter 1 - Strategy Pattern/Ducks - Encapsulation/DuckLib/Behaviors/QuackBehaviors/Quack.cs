using System;

using DuckLib.Interfaces;

namespace DuckLib.Behaviors
{
    public class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
