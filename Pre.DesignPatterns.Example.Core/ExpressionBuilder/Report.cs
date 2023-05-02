namespace Pre.DesignPatterns.Example.Core.ExpressionBuilder;

public abstract class Report
{
    public string Name { get; protected set; }

    public Report()
    {
        
    }

    public Report(string name)
    {
        Name = name;
    }
}