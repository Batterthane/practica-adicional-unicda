// Exercism practica 20 Isandel Abreu

//Faceid Verification /////Face ID 2.0

using System.Collections.Generic;

public record FacialFeatures(string EyeColor, decimal PhiltrumWidth);

public record Identity(string Email, FacialFeatures FacialFeatures);

public class Authenticator
{
    private readonly Identity _admin = new("admin@exerc.ism", new FacialFeatures("green", 0.9m));
    private readonly HashSet<Identity> _registeredIdentities = new();
    
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB) => faceA.Equals(faceB);

    public bool IsAdmin(Identity identity) => identity.Equals(_admin);

    public bool Register(Identity identity) => _registeredIdentities.Add(identity);

    public bool IsRegistered(Identity identity) => _registeredIdentities.Contains(identity);

    public static bool AreSameObject(Identity identityA, Identity identityB) => ReferenceEquals(identityA, identityB);
}

class Program
{
    static void Main()
    {
        FacialFeatures face1 = new FacialFeatures("green", 0.9m);
        FacialFeatures face2 = new FacialFeatures("green", 0.9m);

        Identity identity1 = new Identity("user@example.com", face1);

        Authenticator authenticator = new Authenticator();

        Console.WriteLine("Same face: " +
            Authenticator.AreSameFace(face1, face2));

        Console.WriteLine("Is admin: " +
            authenticator.IsAdmin(
                new Identity(
                    "admin@exerc.ism",
                    new FacialFeatures("green", 0.9m))));

        Console.WriteLine("Registered: " +
            authenticator.Register(identity1));

        Console.WriteLine("Is registered: " +
            authenticator.IsRegistered(identity1));

        Console.WriteLine("Same object: " +
            Authenticator.AreSameObject(identity1, identity1));
    }
}