
namespace Pre.DesignPatterns.Example.Core.ExpressionBuilder;

public class DateExpression : Expression
{
    private string _pattern;
    
    public DateExpression(string formula, string pattern) : base(formula)
    {
        _pattern = pattern;
    }

    public override string Interpret(string content)
    {
        return content.Replace(_formula, DateTime.Now.ToString(_pattern));
    }
}