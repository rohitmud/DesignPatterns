using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public abstract class AbsDuck
    {
        public IFlyBehaviour flyBehaviour;
        public IQuackBehaviour quackBehaviour;
        public abstract void swim();
        public void SetFlybehaviour(IFlyBehaviour ifb)
        {
            flyBehaviour = ifb;
        }
        public void SetQuackbehaviour(IQuackBehaviour iqb)
        {
            quackBehaviour = iqb;
        }
    }

    public class CommonDuck : AbsDuck
    {
        public override void swim()
        {
            Console.WriteLine("Duck Swimming");
        }
    }

    public class PlasticlDuck : AbsDuck
    {
        public override void swim()
        {
            Console.WriteLine("Plastic Duck Swimming");
        }
    }
}
