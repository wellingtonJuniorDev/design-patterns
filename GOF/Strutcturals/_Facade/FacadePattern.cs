using GOF.Strutcturals._Facade.Generic;
using GOF.Strutcturals._Facade.RealWorld;

namespace GOF.Strutcturals._Facade
{
    /// <summary>
    /// <para>The Facade desing pattern provides a unified interface to a set of interfaces in a subsystem.</para>
    /// <para>This pattern defines a higher-level interface that makes the subsystem easier to use.</para>
    /// </summary>
    public class FacadePattern : IDesignPattern
    {
        public void GenericCase()
        {
            var facade = new Facade();

            facade.MethodA();
            facade.MethodB();
        }

        public void RealLifeCase()
        {
            var mortgage = new Mortgage();

            var customer = new Customer("Ann McKinsey");
            bool elegible = mortgage.IsElegible(customer, 125000);

            var result = elegible ? "Approved" : "Rejected";
            Console.WriteLine($"\n{customer.Name} has been {result}");
        }
    }
}
