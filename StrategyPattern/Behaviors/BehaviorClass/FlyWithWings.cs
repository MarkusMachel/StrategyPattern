using StrategyPattern.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class FlyWithWings : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I am flying!");
        }
    }
}
