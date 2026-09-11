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