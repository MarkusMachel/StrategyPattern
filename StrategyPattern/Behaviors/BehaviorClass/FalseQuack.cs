﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Behaviors.BehaviorClass
{
    public class FalseQuack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("false quaaack!");
        }
    }
}
