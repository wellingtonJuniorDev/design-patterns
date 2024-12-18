﻿using GOF;

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
        var desingPattern = DesignPatterns.patterns[option];

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
