using StrategyPattern.Behaviors.BehaviorClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            IQuackBehavior = new Quack();
            IFlyBehavior = new FlyWithWings();
        }
        public override void display()
        {
            throw new NotImplementedException();
        }

        public override void swim()
        {
            throw new NotImplementedException();
        }
    }
}
