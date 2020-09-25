using System;

using DuckLib.Interfaces;

namespace DuckLib.Behaviors
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak!");
        }
    }
}
