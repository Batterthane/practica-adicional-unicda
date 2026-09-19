// Exercism practica 11 Isandel Abreu

//Wizards and Warriors

// Exercism practica 11 Isandel Abreu

// Wizards and Warriors

using System;

abstract class Character
{
    private readonly string _characterType;

    protected Character(string characterType)
    {
        _characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => false;

    public override string ToString() => $"Character is a {_characterType}";
}

class Warrior : Character
{
    public Warrior() : base(nameof(Warrior))
    {
    }

    public override int DamagePoints(Character target) => target.Vulnerable() ? 10 : 6;
}

class Wizard : Character
{
    private bool _preparedSpell;

    public Wizard() : base(nameof(Wizard))
    {
    }

    public override int DamagePoints(Character target) => _preparedSpell ? 12 : 3;

    public void PrepareSpell()
    {
        _preparedSpell = true;
    }

    public override bool Vulnerable() => !_preparedSpell;
}


class Program
{
    static void Main()
    {
        Warrior warrior = new Warrior();
        Wizard wizard = new Wizard();

        Console.WriteLine(warrior);
        Console.WriteLine(wizard);

        Console.WriteLine();

        Console.WriteLine("Daño del guerrero al mago: " +
            warrior.DamagePoints(wizard));

        Console.WriteLine("¿El mago es vulnerable?: " +
            wizard.Vulnerable());

        wizard.PrepareSpell();

        Console.WriteLine();

        Console.WriteLine("El mago preparó su hechizo.");

        Console.WriteLine("¿El mago es vulnerable?: " +
            wizard.Vulnerable());

        Console.WriteLine("Daño del mago al guerrero: " +
            wizard.DamagePoints(warrior));

        Console.WriteLine("Daño del guerrero al mago: " +
            warrior.DamagePoints(wizard));

        Console.ReadKey();
    }
}