using GOF.Strutcturals._Adapter.Generic;
using GOF.Strutcturals._Adapter.RealWorld;

namespace GOF.Strutcturals._Adapter
{
    /// <summary>
    /// <para>The Adapter design pattern converts the interface of a class into another interface clients expect.</para>
    /// <para>This design pattern lets classes work together that couldn't otherwise because of incompatible interfaces.</para>
    /// </summary>
    public class AdapterPattern : IDesignPattern
    {
        public void GenericCase()
        {
            Target target = new Adapter();
            target.Request();
        }

        public void RealLifeCase()
        {
            var unkown = new Compound();
            unkown.Display();

            var water = new RichCompound(Chemical.Water);
            water.Display();

            var benzene = new RichCompound(Chemical.Benzene);
            benzene.Display();

            var ethanol = new RichCompound(Chemical.Ethanol);
            ethanol.Display();
        }
    }
}
