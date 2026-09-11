// Exercism practica 10 Isandel Abreu

//NEED OFR SPEED

using System;

class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class

    private int Speed {get; set;}
    private int BatteryDrain {get; set;}
    private int driven = 0;
    private int battery = 100;
    
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.Speed = speed;
        this.BatteryDrain = batteryDrain;
        int driven = 0;
        int battery = 100;
    }
        
    public bool BatteryDrained()
    {
        bool drained = false;
        if (battery < BatteryDrain)
        {
            drained = true;
        }
        return drained;   
    }

    public int DistanceDriven() => driven;
    
    public void Drive()
    {
        if (battery >= BatteryDrain)
        {
            driven += Speed;
            battery -= BatteryDrain;
        }
               
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);       
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
   
    
    public int Distance {get; set;}
        
    public RaceTrack(int distance)
    {
        this.Distance = distance;        
    }

    public bool TryFinishTrack(RemoteControlCar car) 
    {
        bool empty = car.BatteryDrained();
        while (empty == false)
        {
            car.Drive();
            empty = car.BatteryDrained();
        }
        return car.DistanceDriven() >= Distance;           
    }
    
}