using StrategyPattern.Behaviors;
using StrategyPattern.Behaviors.BehaviorClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Hunter
{
    public class Hunter
    {
        IQuackBehavior quakBehavior;

        public Hunter()
        {
            quakBehavior = new FalseQuack();
        }
        public void FalseQuack()
        {
            quakBehavior.quack();
        }
    }
}
