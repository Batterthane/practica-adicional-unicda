// Exercism practica 5 Isandel Abreu

//Cars, Assemble! 

public static class AssemblyLine
{
    private const int CarsPerHour = 221;

    public static double ProductionRatePerHour(int speed) =>
        SuccessRate(speed) * CarsPerHour * speed;

    public static double SuccessRate(int speed) =>
        speed switch
        {
            >= 1 and <= 4 => 1.0,
            >= 5 and <= 8 => 0.9,
            9 => 0.8,
            10 => 0.77,
            _ => 0.0
        };

    public static int WorkingItemsPerMinute(int speed) =>
        (int) (ProductionRatePerHour(speed) / 60);
}

class Program
{
    static void Main()
    {
        int speed = 6;

        Console.WriteLine("Velocidad: " + speed);
        Console.WriteLine("Producción por hora: " +
            AssemblyLine.ProductionRatePerHour(speed));

        Console.WriteLine("Porcentaje de éxito: " +
            AssemblyLine.SuccessRate(speed));

        Console.WriteLine("Autos por minuto: " +
            AssemblyLine.WorkingItemsPerMinute(speed));
    }
}