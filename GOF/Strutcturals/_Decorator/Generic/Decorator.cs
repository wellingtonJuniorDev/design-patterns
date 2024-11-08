namespace GOF.Strutcturals._Decorator.Generic
{
    public abstract class Decorator : Component
    {
        protected Component component;

        public void SetComponent(Component component) => this.component = component;

        public override void Operation() => component?.Operation();
    }

    public class ConcreteDecoratorA : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorA.Operation");
        }
    }

    public class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorB.Operation");
        }

        void AddedBehavior() { }
    }
}
