// Exercism practica 13 Isandel Abreu

//Logs, Logs, Logs! 

// TODO: define the 'LogLevel' enum
public enum LogLevel{
        Unknown = 0,
        Trace = 1,
        Debug = 2,
        Info = 4,
        Warning = 5,
        Error = 6,
        Fatal = 42
    }
static class LogLine
{
    
    public static LogLevel ParseLogLevel(string logLine)
    {
       if(logLine.Contains("TRC"))
           return LogLevel.Trace;
        else if (logLine.Contains("DBG"))
            return LogLevel.Debug;
        else if (logLine.Contains("INF"))
            return LogLevel.Info;
        else if (logLine.Contains("WRN"))
            return LogLevel.Warning;
        else if (logLine.Contains("ERR"))
            return LogLevel.Error;
        else if (logLine.Contains("FTL"))
            return LogLevel.Fatal;
        else 
            return LogLevel.Unknown;
    }

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
       return  $"{(int)logLevel}:{message}";
    }
}

class Program
{
    static void Main()
    {
        string log1 = "[INF]: File opened successfully.";
        string log2 = "[ERR]: Unable to open file.";
        string log3 = "[FTL]: System failure.";

        LogLevel level1 = LogLine.ParseLogLevel(log1);
        LogLevel level2 = LogLine.ParseLogLevel(log2);
        LogLevel level3 = LogLine.ParseLogLevel(log3);

        Console.WriteLine("Log 1: " + level1);
        Console.WriteLine("Log 2: " + level2);
        Console.WriteLine("Log 3: " + level3);

        Console.WriteLine();

        Console.WriteLine(
            LogLine.OutputForShortLog(level1, "File opened successfully.")
        );

        Console.WriteLine(
            LogLine.OutputForShortLog(level2, "Unable to open file.")
        );

        Console.WriteLine(
            LogLine.OutputForShortLog(level3, "System failure.")
        );

        Console.ReadKey();
    }
}