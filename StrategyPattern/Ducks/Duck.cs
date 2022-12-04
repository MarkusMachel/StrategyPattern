using StrategyPattern.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public abstract class Duck
    {
        public IFlyBehavior IFlyBehavior;
        public IQuackBehavior IQuackBehavior; 
        public abstract void swim();
        public abstract void display();
        public void performFly()
        {
            IFlyBehavior.fly();
        }
        public void peformQuack()
        {
            IQuackBehavior.quack();
        }
        public void setFlyBehavior(IFlyBehavior fb)
        {
            IFlyBehavior = fb;
        }
        public void setQuackBehavior(IQuackBehavior qb)
        {
            IQuackBehavior = qb;
        }
    }
}
