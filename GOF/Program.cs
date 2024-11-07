using GOF;
using GOF.Creationals._AbstractFactory;
using GOF.Creationals._Builder;
using GOF.Creationals._FactoryMethod;
using GOF.Creationals._Prototype;
using GOF.Creationals._Singleton;
using GOF.Strutcturals._Adapter;

var patterns = new Dictionary<GofPattern, IDesignPattern>
{
    { GofPattern.AbstractFactory, new AbstractFactoryPattern() },
    { GofPattern.Builder, new BuilderPattern() },
    { GofPattern.FactoryMethod, new FactoryMethodPattern() },
    { GofPattern.Prototype, new PrototypeMethodPattern() },
    { GofPattern.Singleton, new SingletonPattern() },
    { GofPattern.Adapter, new AdapterPattern() },
};

GofPattern option;
do
{
    Console.WriteLine("MENU OPTIONS");
    foreach(var pattern in Enum.GetValues<GofPattern>())
    {
        Console.WriteLine($"{pattern.GetHashCode()}: {pattern}");
    }

    Console.Write("Select the design pattern option: ");

    if (!Enum.TryParse(Console.ReadLine(), out option))
    {
        Console.WriteLine("Invalid option, try again...");
    }
    else if (option != GofPattern.None)
    {
        Console.WriteLine($"\nRunning {option} pattern \n");
        var desingPattern = patterns[option];

        Console.WriteLine("GENERIC CASE: \n");
        desingPattern.GenericCase();

        Console.WriteLine("\nREAL LIFE CASE: \n");
        desingPattern.RealLifeCase();

        Console.ReadKey();
        Console.WriteLine("Press any key to continue");
        Console.Clear();
    }
}
while (option != GofPattern.None);
