// Exercism practica 12 Isandel Abreu

//Wizards and Warriors 2.0

using System;

static class GameMaster
{
    public static string Describe(Character c)
        => $"You're a level {c.Level} {c.Class} with {c.HitPoints} hit points.";

    public static string Describe(Destination d)
        => $"You've arrived at {d.Name}, which has {d.Inhabitants} inhabitants.";

    public static string Describe(TravelMethod t)
        => $"You're traveling to your destination {(t == 0 ? "by walking" : "on horseback")}.";

    public static string Describe(Character c, Destination d, TravelMethod t = 0)
        => $"{Describe(c)} {Describe(t)} {Describe(d)}";
}

class Character
{
    public string Class { get; set; } = "";
    public int Level { get; set; }
    public int HitPoints { get; set; }
}

class Destination
{
    public string Name { get; set; } = "";
    public int Inhabitants { get; set; }
}

enum TravelMethod
{
    Walking = 0,
    Horseback = 1
}


class Program
{
    static void Main()
    {
        Character character = new Character
        {
            Class = "Wizard",
            Level = 10,
            HitPoints = 100
        };

        Destination destination = new Destination
        {
            Name = "Castle",
            Inhabitants = 500
        };

        Console.WriteLine(GameMaster.Describe(character));

        Console.WriteLine(GameMaster.Describe(destination));

        Console.WriteLine(GameMaster.Describe(TravelMethod.Walking));

        Console.WriteLine(GameMaster.Describe(TravelMethod.Horseback));

        Console.WriteLine();

        Console.WriteLine(
            GameMaster.Describe(
                character,
                destination,
                TravelMethod.Horseback
            )
        );

        Console.ReadKey();
    }
}