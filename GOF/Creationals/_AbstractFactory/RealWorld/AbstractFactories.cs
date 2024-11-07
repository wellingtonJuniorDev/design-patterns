namespace GOF.Creationals._AbstractFactory.RealWorld
{
    public interface IContinentFactory
    {
        ICarnivore CreateCarnivore();
        IHerbivore CreateHerbivore();
    }
}
