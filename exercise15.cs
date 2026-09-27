// Exercism practica 15 Isandel Abreu

//Remote Control Car Conundrum

using System;
using System.Collections.Generic;
using System.Linq;

public interface IRemoteControlCar
{
    void Drive();
    int DistanceTravelled { get; }
}

public class ProductionRemoteControlCar : IRemoteControlCar, IComparable<ProductionRemoteControlCar>
{
    public int DistanceTravelled { get; private set; }
    public int NumberOfVictories { get; set; }

    public void Drive()
    {
        DistanceTravelled += 10;
    }

    public int CompareTo(ProductionRemoteControlCar other) => NumberOfVictories.CompareTo(other.NumberOfVictories);
}

public class ExperimentalRemoteControlCar : IRemoteControlCar
{
    public int DistanceTravelled { get; private set; }

    public void Drive()
    {
        DistanceTravelled += 20;
    }
}

public static class TestTrack
{
    public static void Race(IRemoteControlCar car)
    {
        car.Drive();
    }

    public static List<ProductionRemoteControlCar> GetRankedCars(ProductionRemoteControlCar prc1, ProductionRemoteControlCar prc2) =>
        new List<ProductionRemoteControlCar> { prc1, prc2 }.OrderBy(x => x).ToList();
}

class Program
{
    static void Main()
    {
        ProductionRemoteControlCar productionCar = new ProductionRemoteControlCar();
        ExperimentalRemoteControlCar experimentalCar = new ExperimentalRemoteControlCar();

        productionCar.NumberOfVictories = 5;

        TestTrack.Race(productionCar);
        TestTrack.Race(experimentalCar);

        Console.WriteLine("Production car distance: " + productionCar.DistanceTravelled);
        Console.WriteLine("Experimental car distance: " + experimentalCar.DistanceTravelled);

        ProductionRemoteControlCar car1 = new ProductionRemoteControlCar();
        ProductionRemoteControlCar car2 = new ProductionRemoteControlCar();

        car1.NumberOfVictories = 3;
        car2.NumberOfVictories = 7;

        List<ProductionRemoteControlCar> rankedCars =
            TestTrack.GetRankedCars(car1, car2);

        Console.WriteLine("Cars ranked:");
        foreach (ProductionRemoteControlCar car in rankedCars)
        {
            Console.WriteLine("Victories: " + car.NumberOfVictories);
        }
    }
}