using StrategyPattern.Behaviors.BehaviorClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            IFlyBehavior = new FlyNoWay();
            IQuackBehavior = new Quack();
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
