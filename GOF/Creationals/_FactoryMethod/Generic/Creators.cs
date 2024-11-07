namespace GOF.Creationals._FactoryMethod.Generic
{
    public abstract class Creator
    {
        public abstract Product FactoryMethod();
    }

    public class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }

    public class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}
