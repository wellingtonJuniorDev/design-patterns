using GOF.Strutcturals._Decorator.Generic;
using GOF.Strutcturals._Decorator.RealWorld;

namespace GOF.Strutcturals._Decorator
{
    /// <summary>
    /// <para>The Decorator desing pattern attaches additional responsabilities to an object dynamically.</para>
    /// <para>This pattern provide a flexible alternative to subclassing for extending functionality.</para>
    /// </summary>
    public class DecoratorPattern : IDesignPattern
    {
        public void GenericCase()
        {
            var component = new ConcreteComponent();
            var decoratorA = new ConcreteDecoratorA();
            var decoratorB = new ConcreteDecoratorB();

            decoratorA.SetComponent(component);
            decoratorB.SetComponent(decoratorA);

            decoratorB.Operation();
        }

        public void RealLifeCase()
        {
            var book = new Book("Worley", "Inside ASP.NET", 10);
            book.Display();

            var video = new Video("Spielberg", "Jaws", 23, 92);
            video.Display();

            Console.WriteLine("\n Making video borrowable:");

            var borrow = new Borrowable<Video>(video);
            borrow.BorrowItem("Customer #1");
            borrow.BorrowItem("Customer #2");

            borrow.Display();
        }
    }
}
