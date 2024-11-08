using GOF.Strutcturals._Bridge.Generic;
using GOF.Strutcturals._Bridge.RealWorld;

namespace GOF.Strutcturals._Bridge
{
    /// <summary>
    /// The Bridge design pattern decouples an abstraction from its implementation so that the two can vary independently
    /// </summary>
    public class BridgePattern : IDesignPattern
    {
        public void GenericCase()
        {
            Abstraction abstraction = new RefinedAbstraction();

            abstraction.Implementor = new ConcreteImplementorA();
            abstraction.Operation();

            abstraction.Implementor = new ConcreteImplementorB();
            abstraction.Operation();
        }

        public void RealLifeCase()
        {
            CustomersBase customers = new Customers(new CustomersData("Chicago"));

            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();

            customers.Add("Henry Velasquez");
            customers.ShowAll();
        }
    }
}
