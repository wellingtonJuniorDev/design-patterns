namespace GOF.Creationals._AbstractFactory.Generic
{
    public class ProductA1 : AbstractProductA
    {

    }

    public class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(GetType().Name + " interacts with " + a.GetType().Name);
        }
    }

    public class ProductA2 : AbstractProductA
    {

    }

    public class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(GetType().Name + " interacts with " + a.GetType().Name);
        }
    }
}
