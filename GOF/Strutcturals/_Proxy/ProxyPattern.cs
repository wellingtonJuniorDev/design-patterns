using GOF.Strutcturals._Proxy.Generic;
using GOF.Strutcturals._Proxy.RealWorld;

namespace GOF.Strutcturals._Proxy
{
    /// <summary>
    /// The Proxy design pattern provides a surrogate or placeholder for another object to control access to it.
    public class ProxyPattern : IDesignPattern
    {
        public void GenericCase()
        {
            var proxy = new Proxy();
            proxy.Request();
        }

        public void RealLifeCase()
        {
            var proxy = new MathProxy();

            Console.WriteLine($"4 + 2 = {proxy.Add(4, 2)}");
            Console.WriteLine($"4 - 2 = {proxy.Subtract(4, 2)}");
            Console.WriteLine($"4 * 2 = {proxy.Multiply(4, 2)}");
            Console.WriteLine($"4 / 2 = {proxy.Divide(4, 2)}");
        }
    }
}
