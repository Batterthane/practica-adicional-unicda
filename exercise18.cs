// Exercism practica 18 Isandel Abreu

//Weighing Machine 

using System;

public sealed class WeighingMachine
{
    double _weight;

    public WeighingMachine(int precision)
    {
        Precision = precision;
    }

    public int Precision { get; }
    public double TareAdjustment { get; set; } = 5.0;

    public double Weight
    {
        get => _weight;
        set
        {
            ArgumentOutOfRangeException.ThrowIfNegative(value);
            _weight = value;
        }
    }

    public string DisplayWeight
    {
        get
        {
            var fmt = $"N{Precision}";
            var math = Math.Round((_weight - TareAdjustment), Precision).ToString(fmt);
            return $"{math} kg";
        }
    }
}

class Program
{
    static void Main()
    {
        WeighingMachine machine = new WeighingMachine(2);

        machine.Weight = 75.5;

        Console.WriteLine("Weight: " + machine.Weight);
        Console.WriteLine("Display weight: " + machine.DisplayWeight);

        machine.TareAdjustment = 3.0;

        Console.WriteLine("Display weight after tare adjustment: " + machine.DisplayWeight);
    }
}