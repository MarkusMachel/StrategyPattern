// See https://aka.ms/new-console-template for more information
using StrategyPattern;
using StrategyPattern.Behaviors.BehaviorClass;
using StrategyPattern.Ducks;
using StrategyPattern.Hunter;

Console.WriteLine("Hello, World!");
Duck duck = new MallardDuck();
duck.peformQuack();
duck.performFly();


var modelDuck = new ModelDuck();
modelDuck.performFly();
modelDuck.setFlyBehavior(new FlyRocketPowered());
modelDuck.performFly();

var hunter = new Hunter();
hunter.FalseQuack();