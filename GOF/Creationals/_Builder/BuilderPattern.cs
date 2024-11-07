using GOF.Creationals._Builder.Generic;
using GOF.Creationals._Builder.RealWorld;

namespace GOF.Creationals._Builder
{
    /// <summary>
    /// The Builder design pattern separates the construction of a complex object from its representation so that the same construction process can create different representations. 
    /// </summary>
    internal class BuilderPattern : IDesignPattern
    {
        public void GenericCase()
        {
            var director = new Director();

            Builder builder1 = new ConcreteBuilder1();
            Builder builder2 = new ConcreteBuilder2();

            director.Construct(builder1);
            Product product1 = builder1.GetResult();
            product1.Show();
            
            director.Construct(builder2);
            Product product2 = builder2.GetResult();
            product2.Show();
        }

        public void RealLifeCase()
        {
            var shop = new Shop();

            List<VehicleBuilder> builders = [ 
                new ScooterBuilder(), 
                new CarBuilder(), 
                new MotorcyleBuilder() 
            ];

            builders.ForEach(builder =>
            {
                shop.Construct(builder);
                shop.ShowVehicle();
            });
        }
    }
}
