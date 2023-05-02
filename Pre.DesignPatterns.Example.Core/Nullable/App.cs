using Pre.DesignPatterns.Example.Core.Singleton;

namespace Pre.DesignPatterns.Example.Core.Nullable;

public class App
{

    private int number;
    private int? number2;

    public void WriteContent(Info? info)
    {
        if (info == null) return;
        Console.WriteLine(info.Content);
    }

    public void Run()
    {
        Info? a = null;
        Info b = new Info();
        Info c = new Info("This is some content");
        
        WriteContent(a);
    }
}