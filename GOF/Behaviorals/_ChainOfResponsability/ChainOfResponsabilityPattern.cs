using GOF.Behaviorals._ChainOfResponsability.Generic;
using GOF.Behaviorals._ChainOfResponsability.RealWorld;

namespace GOF.Behaviorals._ChainOfResponsability
{
    /// <summary>
    /// <para>The Chain of Responsibility design pattern avoids coupling the sender of a request to its receiver by giving more than one object a chance to handle the request.</para>
    /// <para>This pattern chains the receiving objects and passes the request along the chain until an object handles it.</para>
    /// </summary>
    public class ChainOfResponsabilityPattern : IDesignPattern
    {
        public void GenericCase()
        {
            Handler handler1 = new ConcreteHandler1();
            Handler handler2 = new ConcreteHandler2();
            Handler handler3 = new ConcreteHandler3();

            handler1.SetSucessor(handler2);
            handler2.SetSucessor(handler3);

            int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

            foreach (var request in requests)
            {
                handler1.HandleRequest(request);
            }
        }

        public void RealLifeCase()
        {
            var larry = new Director();
            var sam = new VicePresident();
            var tammy = new President();

            larry.Successor = sam;
            sam.Successor = tammy;

            var purchase = new Purchase { Number = 2034, Amount = 350.00, Purpose = "Supplies" };
            larry.ProcessRequest(purchase);

            purchase = new Purchase { Number = 2035, Amount = 32590.10, Purpose = "Project X" };
            larry.ProcessRequest(purchase);

            purchase = new Purchase { Number = 2036, Amount = 122100.00, Purpose = "Project Y" };
            larry.ProcessRequest(purchase);
        }
    }
}
