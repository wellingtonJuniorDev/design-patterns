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
        
        AbstractFactory = 1,
        Builder = 2,
        FactoryMethod = 3,
        Prototype = 4,


    }
}