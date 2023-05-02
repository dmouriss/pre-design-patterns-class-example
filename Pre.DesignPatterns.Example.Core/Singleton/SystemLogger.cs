namespace Pre.DesignPatterns.Example.Core.Singleton;

public class SystemLogger
{
    public static SystemLogger Instance { get; } = new SystemLogger();

    private SystemLogger()
    {
        
    }

    public void Log(string title, string message)
    {
        Console.WriteLine($"Write the following to the file: {title} {message}");
    }
}