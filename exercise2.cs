// Exercism practica 2 Isandel Abreu

//Luci's Luscious Lasagna 

class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        return 40;
    }
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int actual)
    {
        return ExpectedMinutesInOven() - actual;
    }
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers)
    {
        return layers * 2;
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int actual)
    {
        return PreparationTimeInMinutes(layers) + actual;
    }
}

class Program
{
    static void Main()
    {
        Lasagna lasagna = new Lasagna();

        Console.WriteLine(lasagna.ExpectedMinutesInOven());

        Console.WriteLine(lasagna.RemainingMinutesInOven(30));

        Console.WriteLine(lasagna.PreparationTimeInMinutes(3));

        Console.WriteLine(lasagna.ElapsedTimeInMinutes(3, 30));
    }
}