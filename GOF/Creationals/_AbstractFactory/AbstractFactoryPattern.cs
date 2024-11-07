using GOF.Creationals._AbstractFactory.Generic;
using GOF.Creationals._AbstractFactory.RealWorld;

namespace GOF.Creationals._AbstractFactory
{
    /// <summary>
    /// The Abstract Factory design pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes. 
    /// </summary>
    public class AbstractFactoryPattern : IDesignPattern
    {
        public void GenericCase()
        {
            AbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run();


            AbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run();
        }

        public void RealLifeCase()
        {
            IAnimalWorld africa = new AnimalWorld<Africa>();
            africa.RunFoodChain();

            IAnimalWorld america = new AnimalWorld<America>();
            america.RunFoodChain();
        }
    }
}
