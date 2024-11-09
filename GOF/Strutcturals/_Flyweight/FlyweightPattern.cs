using GOF.Strutcturals._Flyweight.Generic;
using GOF.Strutcturals._Flyweight.RealWorld;

namespace GOF.Strutcturals._Flyweight
{
    /// <summary>
    /// The Flyweight desing pattern uses sharing to support large numbers of fine-grained objects efficiently
    /// </summary>
    public class FlyweightPattern : IDesignPattern
    {
        public void GenericCase()
        {
            int extrinsicstate = 22;

            var factory = new FlyweightFactory();

            Flyweight fx = factory.GetFlyweight("X");
            fx.Operation(--extrinsicstate);

            Flyweight fy = factory.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);

            Flyweight fz = factory.GetFlyweight("Z");
            fz.Operation(--extrinsicstate);

            UnsharedConcreteFlyweight fu = new UnsharedConcreteFlyweight();
            fu.Operation(--extrinsicstate);
        }

        public void RealLifeCase()
        {
            var document = "AAZZBBZB";

            var factory = new CharacterFactory();
            int pointSize = 10;

            foreach (var c in document)
            {
                var character = factory.GetCharacter(c);
                character.Display(++pointSize);
            }
        }
    }
}
