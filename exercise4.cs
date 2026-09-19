// Exercism practica 4 Isandel Abreu

//Log Levels 

static class LogLine
{
    public static string Message(string logLine) =>
        logLine[(logLine.IndexOf(':') + 1)..].Trim();

    public static string LogLevel(string logLine) =>
        logLine[1..logLine.IndexOf(']')].ToLower();

    public static string Reformat(string logLine) =>
        $"{Message(logLine)} ({LogLevel(logLine)})";
}

class Program
{
    static void Main()
    {
        string logLine = "[ERROR]: Stack overflow";

        Console.WriteLine("Mensaje: " + LogLine.Message(logLine));
        Console.WriteLine("Nivel: " + LogLine.LogLevel(logLine));
        Console.WriteLine("Reformateado: " + LogLine.Reformat(logLine));
    }
}