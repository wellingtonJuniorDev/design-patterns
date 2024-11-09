namespace GOF.Strutcturals._Proxy.Generic
{
    public abstract class Subject
    {
        public abstract void Request();
    }

    public class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("Calling RealSubject.Request()");
        }
    }

    public class Proxy : Subject
    {
        RealSubject realSubject;

        public override void Request()
        {
            realSubject ??= new RealSubject();
            realSubject.Request();
        }
    }
}
