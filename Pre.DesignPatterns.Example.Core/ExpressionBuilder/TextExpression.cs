namespace Pre.DesignPatterns.Example.Core.ExpressionBuilder;

public class TextExpression : Expression
{
    private string _value;
    
    public TextExpression(string formula, string value) : base(formula)
    {
        _value = value;
    }

    public override string Interpret(string content)
    {
        return content.Replace(_formula, _value);
    }
}