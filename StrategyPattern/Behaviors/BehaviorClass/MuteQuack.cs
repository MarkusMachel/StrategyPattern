using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Behaviors.BehaviorClass
{
    internal class MuteQuack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Can´t quack!");
        }
    }
}
