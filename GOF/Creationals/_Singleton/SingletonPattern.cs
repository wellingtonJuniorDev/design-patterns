using GOF.Creationals._Singleton.Generic;
using GOF.Creationals._Singleton.RealWorld;

namespace GOF.Creationals._Singleton
{
    public class SingletonPattern : IDesignPattern
    {
        public void GenericCase()
        {
            Singleton singleton1 = Singleton.Instance();
            Singleton singleton2 = Singleton.Instance();

            if (singleton1 == singleton2)
            {
                Console.WriteLine("Objects are the same instance");
            }           
        }

        public void RealLifeCase()
        {
            var balancer1 = LoadBalancer.GetLoadBalancer();
            var balancer2 = LoadBalancer.GetLoadBalancer();
            var balancer3 = LoadBalancer.GetLoadBalancer();
            var balancer4 = LoadBalancer.GetLoadBalancer();

            if (balancer1 == balancer2 && balancer2 == balancer3 && balancer3 == balancer4)
            {
                Console.WriteLine("Same instance\n");
            }

            var balancer = LoadBalancer.GetLoadBalancer();

            // Load balance 10 requests for a server
            for (var i = 0; i < 10; i++)
            {
                var server = balancer.NextServer.Name;
                Console.WriteLine($"Dispatch request to {server}");
            }
        }
    }
}
