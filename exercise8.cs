// Exercism practica 8 Isandel Abreu

//Elon's Toys

class RemoteControlCar
{
    private int Distance;
    
    private int BatteryLevel = 100;
    
    public static RemoteControlCar Buy() => new();

    public string DistanceDisplay() => $"Driven {Distance} meters";

    public string BatteryDisplay()
    {
        if (BatteryLevel == 0)
        {
            return "Battery empty";
        }
        return $"Battery at {BatteryLevel}%";
    }
    
    public void Drive()
    {
        if (BatteryLevel <= 0) return;
        BatteryLevel -= 1;
        Distance += 20;
    }
}

class Program
{
    static void Main()
    {
        RemoteControlCar car = RemoteControlCar.Buy();

        Console.WriteLine(car.DistanceDisplay());
        Console.WriteLine(car.BatteryDisplay());

        car.Drive();
        car.Drive();
        car.Drive();

        Console.WriteLine(car.DistanceDisplay());
        Console.WriteLine(car.BatteryDisplay());

        Console.ReadKey();
    }
}