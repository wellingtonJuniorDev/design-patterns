namespace GOF.Creationals._AbstractFactory.RealWorld
{
    public class Africa : IContinentFactory
    {
        public ICarnivore CreateCarnivore() => new Lion();
        public IHerbivore CreateHerbivore() => new Wildebeest();
    }

    public class America : IContinentFactory
    {
        public ICarnivore CreateCarnivore() => new Wolf();
        public IHerbivore CreateHerbivore() => new Bison();
    }
}
