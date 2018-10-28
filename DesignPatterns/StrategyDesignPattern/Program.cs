using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbsDuck CmnDuck = new CommonDuck();
            IFlyBehaviour Flybehaviour = new NoFlying();
            IQuackBehaviour QuackBehaviour = new NormalQuack();
            CmnDuck.SetFlybehaviour(Flybehaviour);
            CmnDuck.SetQuackbehaviour(QuackBehaviour);

            AbsDuck PlsticDuck = new PlasticlDuck();
            Flybehaviour = new NoFlying();
            QuackBehaviour = new NoQuack();
            PlsticDuck.SetFlybehaviour(Flybehaviour);
            PlsticDuck.SetQuackbehaviour(QuackBehaviour);
            CmnDuck.swim();
            CmnDuck.flyBehaviour.Fly();
            CmnDuck.quackBehaviour.Quack();

            PlsticDuck.swim();
            PlsticDuck.flyBehaviour.Fly();
            PlsticDuck.quackBehaviour.Quack();

            Console.WriteLine("Upgrading CmnDuck Flying and Quacking");
            CmnDuck.SetFlybehaviour(new JetFlying());
            CmnDuck.SetQuackbehaviour(new SpecialQuack());
            CmnDuck.flyBehaviour.Fly();
            CmnDuck.quackBehaviour.Quack();



            Console.ReadLine();
        }
    }
}
