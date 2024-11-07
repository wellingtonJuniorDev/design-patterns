namespace GOF.Creationals._AbstractFactory.RealWorld
{
    public interface IAnimalWorld
    {
        void RunFoodChain();
    }

    public class AnimalWorld<T> : IAnimalWorld where T : IContinentFactory, new()
    {
        private readonly ICarnivore carnivore;
        private readonly IHerbivore herbivore;

        public AnimalWorld()
        {
            var factory = new T();

            carnivore = factory.CreateCarnivore();
            herbivore = factory.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            carnivore.Eat(herbivore);
        }
    }
}
