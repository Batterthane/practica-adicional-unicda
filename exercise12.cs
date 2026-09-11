// Exercism practica 12 Isandel Abreu

//Wizards and Warriors 2.0

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
    public string Class { get; set; }
    public int Level { get; set; }
    public int HitPoints { get; set; }
}
class Destination
{
    public string Name { get; set; }
    public int Inhabitants { get; set; }
}
enum TravelMethod
{
    Walking = 0,
    Horseback = 1
}