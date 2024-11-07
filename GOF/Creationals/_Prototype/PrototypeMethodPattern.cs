using GOF.Creationals._Prototype.Generic;
using GOF.Creationals._Prototype.RealWorld;

namespace GOF.Creationals._Prototype
{
    /// <summary>
    /// The Prototype design pattern specifies the kind of objects to create using a prototypical instance, and create new objects by copying this prototype. 
    /// </summary>
    internal class PrototypeMethodPattern : IDesignPattern
    {
        public void GenericCase()
        {
            ConcretePrototype1 prototype1 = new ConcretePrototype1("I");
            ConcretePrototype1 clone1 = (ConcretePrototype1) prototype1.Clone();
            Console.WriteLine("Cloned {0}", clone1.Id);

            ConcretePrototype2 prototype2 = new ConcretePrototype2("II");
            ConcretePrototype2 clone2 = (ConcretePrototype2) prototype2.Clone();
            Console.WriteLine("Cloned {0}", clone2.Id);
        }

        public void RealLifeCase()
        {
            var manager = new ColorManager();

            manager[ColorType.Red] = new Color { Red = 255, Blue = 0, Green = 0 };
            manager[ColorType.Green] = new Color { Red = 0, Blue = 0, Green = 255 };
            manager[ColorType.Blue] = new Color { Red = 0, Blue = 255, Green = 0 };

            manager[ColorType.Angry] = new Color { Red = 255, Blue = 54, Green = 0 };
            manager[ColorType.Peace] = new Color { Red = 128, Blue = 211, Green = 128 };
            manager[ColorType.Flame] = new Color { Red = 211, Blue = 34, Green = 20 };

            _ = manager[ColorType.Red].Clone();
            _ = manager[ColorType.Peace].Clone();
            _ = manager[ColorType.Flame].Clone(false);
        }
    }
}
