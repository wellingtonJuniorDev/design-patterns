namespace GOF.Creationals._AbstractFactory.RealWorld
{
    public interface IHerbivore
    {

    }

    public interface ICarnivore
    {
        void Eat(IHerbivore herbivore);
    }
}
