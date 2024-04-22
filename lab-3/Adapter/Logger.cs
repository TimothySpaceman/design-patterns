namespace lab_3.Adapter;

public class Logger : ILogger
{
    private const ConsoleColor DefaultFg = ConsoleColor.Gray;
    private const ConsoleColor LogFg = ConsoleColor.Green;
    private const ConsoleColor ErrorFg = ConsoleColor.Red;
    private const ConsoleColor WarnFg = ConsoleColor.Yellow;
    
    public void Log(string message)
    {
        Console.ForegroundColor = LogFg;
        Console.Write($"[{DateTime.Now:ss:mm:HH dd.MM.yyyy}] ");
        Console.ForegroundColor = DefaultFg;
        Console.WriteLine(message);
    }
    
    public void Error(string message)
    {
        Console.ForegroundColor = ErrorFg;
        Console.WriteLine($"ERROR: {message}");
        Console.ForegroundColor = DefaultFg;
    }
    
    public void Warn(string message)
    {
        Console.ForegroundColor = WarnFg;
        Console.WriteLine($"WARNING: {message}");
        Console.ForegroundColor = DefaultFg;
    }
}