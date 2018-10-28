using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public interface IFlyBehaviour
    {
        void Fly();
    }
    public class NormalFlying : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Normal Flying");
        }
    }
    public class NoFlying : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("No Flying");
        }
    }
    public class JetFlying : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Jet Flying");
        }
    }
}
