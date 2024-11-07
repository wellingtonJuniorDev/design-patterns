namespace GOF.Creationals._AbstractFactory.RealWorld
{
    public class Wildebeest : IHerbivore { }

    public class Lion : ICarnivore
    {
        public void Eat(IHerbivore herbivore) => 
            Console.WriteLine($"{GetType().Name} eats {herbivore.GetType().Name}");
    }

    public class Bison : IHerbivore { }

    public class Wolf : ICarnivore
    {
        public void Eat(IHerbivore herbivore) =>
            Console.WriteLine($"{GetType().Name} eats {herbivore.GetType().Name}");
    }
}
