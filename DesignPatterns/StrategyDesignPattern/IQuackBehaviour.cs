using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public interface IQuackBehaviour
    {
         void Quack();
    }

    public class NormalQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Normal Quacking");
        }
    }

    public class NoQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("No Quacking");
        }
    }

    public class ScreamingQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Screaming Quacking");
        }
    }
    public class SpecialQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Special Quacking");
        }
    }

}
