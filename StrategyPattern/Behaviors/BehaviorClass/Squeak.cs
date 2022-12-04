using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Behaviors.BehaviorClass
{
    internal class Squeak : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Squeeeck!");
        }
    }
}
