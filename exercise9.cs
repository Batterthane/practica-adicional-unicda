// Exercism practica 9 Isandel Abreu

//Tracks on Tracks on Tracks 

using System.Collections.Generic;
using System.Linq;

public static class Languages
{
    public static List<string> NewList() => new List<string>();

    public static List<string> GetExistingLanguages()
        => new List<string> { "C#", "Clojure", "Elm" };

    public static List<string> AddLanguage
        (List<string> languages, string language)
        => new List<string>(languages.Concat(new[] { language }));

    public static int CountLanguages(List<string> languages)
    {
        int count = 0;
        foreach (var _ in languages)
            count++;
        return count;
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
        foreach (var lang in languages)
            if (lang == language) return true;
        return false;
    }

    public static List<string> ReverseList(List<string> languages)
    {
        var rev = NewList();
        for (var idx = languages.Count - 1; idx >= 0; idx--)
            rev.Add(languages[idx]);
        return rev;
    }

    public static bool IsExciting(List<string> languages)
    {
        if (CountLanguages(languages) == 0) return false;
        if (languages[0] == "C#") return true;
        if (CountLanguages(languages) >= 2 && CountLanguages(languages) < 4 && languages[1] == "C#") return true;
        return false;
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        var keep = NewList();
        foreach (var lang in languages)
            if (lang != language) keep.Add(lang);
        return keep;
    }

    public static bool IsUnique(List<string> languages)
    {
        var compare = NewList();
        foreach (var lang in languages)
            if (HasLanguage(compare, lang)) return false;
            else compare.Add(lang);
        return true;
    }
}

class Program
{
    static void Main()
    {
        List<string> languages = Languages.GetExistingLanguages();

        Console.WriteLine("Lenguajes existentes:");

        foreach (string language in languages)
        {
            Console.WriteLine(language);
        }

        Console.WriteLine();

        Console.WriteLine("Cantidad de lenguajes: " +
            Languages.CountLanguages(languages));

        Console.WriteLine();

        Console.WriteLine("¿Tiene C#?: " +
            Languages.HasLanguage(languages, "C#"));

        Console.WriteLine();
    

        List<string> added = Languages.AddLanguage(languages, "Python");

        Console.WriteLine("Después de agregar Python:");

        foreach (string language in added)
        {
            Console.WriteLine(language);
        }

        Console.WriteLine();

        List<string> reversed = Languages.ReverseList(languages);

        Console.WriteLine("Lista invertida:");

        foreach (string language in reversed)
        {
            Console.WriteLine(language);
        }

        Console.WriteLine();

        Console.WriteLine("¿Es emocionante?: " +
            Languages.IsExciting(languages));

        List<string> removed = Languages.RemoveLanguage(languages, "Clojure");

        Console.WriteLine("Después de eliminar Clojure:");

        foreach (string language in removed)
        {
            Console.WriteLine(language);
        }

        Console.WriteLine();

        Console.WriteLine("¿Todos los lenguajes son únicos?: " +
            Languages.IsUnique(languages));

        Console.ReadKey();
    }
}