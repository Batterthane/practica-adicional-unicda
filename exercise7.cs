// Exercism practica 7 Isandel Abreu

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