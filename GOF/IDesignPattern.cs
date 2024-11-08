using GOF.Creationals._AbstractFactory;
using GOF.Creationals._Builder;
using GOF.Creationals._FactoryMethod;
using GOF.Creationals._Prototype;
using GOF.Creationals._Singleton;
using GOF.Strutcturals._Adapter;
using GOF.Strutcturals._Bridge;
using GOF.Strutcturals._Composite;
using System.Collections.Immutable;

namespace GOF
{
    public interface IDesignPattern
    {
        void GenericCase();
        void RealLifeCase();
    }

    public enum GofPattern
    {
        None = 0,

        // Creational
        AbstractFactory = 1,
        Builder = 2,
        FactoryMethod = 3,
        Prototype = 4,
        Singleton = 5,

        // Structural
        Adapter = 6,
        Bridge = 7,
        Composity = 8,

    }

    public static class DesignPatterns
    {
        public static readonly ImmutableDictionary<GofPattern, IDesignPattern> patterns = 
            new Dictionary<GofPattern, IDesignPattern>()
            {
                { GofPattern.AbstractFactory, new AbstractFactoryPattern() },
                { GofPattern.Builder, new BuilderPattern() },
                { GofPattern.FactoryMethod, new FactoryMethodPattern() },
                { GofPattern.Prototype, new PrototypeMethodPattern() },
                { GofPattern.Singleton, new SingletonPattern() },
                { GofPattern.Adapter, new AdapterPattern() },
                { GofPattern.Bridge, new BridgePattern() },
                { GofPattern.Composity, new CompositePattern() }
            }
            .ToImmutableDictionary();
    }
}