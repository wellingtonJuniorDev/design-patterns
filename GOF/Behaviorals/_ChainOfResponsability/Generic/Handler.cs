namespace GOF.Behaviorals._ChainOfResponsability.Generic
{
    public abstract class Handler
    {
        protected Handler sucessor;

        public void SetSucessor(Handler sucessor) => 
            this.sucessor = sucessor;

        public abstract void HandleRequest(int request);
    }

    public class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 0 && request < 10)
            {
                Console.WriteLine(
                    "{0} handle request {1}",
                    this.GetType().Name, 
                    request
                );
            }
            else if (sucessor != null)
            {
                sucessor.HandleRequest(request);
            }
        }
    }

    public class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
            {
                Console.WriteLine(
                    "{0} handle request {1}",
                    this.GetType().Name,
                    request
                );
            }
            else if (sucessor != null)
            {
                sucessor.HandleRequest(request);
            }
        }
    }

    public class ConcreteHandler3 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 20 && request < 30)
            {
                Console.WriteLine(
                    "{0} handle request {1}",
                    this.GetType().Name,
                    request
                );
            }
            else if (sucessor != null)
            {
                sucessor.HandleRequest(request);
            }
        }
    }
}
