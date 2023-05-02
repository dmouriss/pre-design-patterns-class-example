namespace Pre.DesignPatterns.Example.Core.ExpressionBuilder;

public class PdfReport : Report
{
    public double Margin { get; set; }
    public string Content { get; set; }

    private ContentParser _parser;

    public PdfReport(string name, double margin)
    {
        Name = name;
        Margin = margin;
    }

    public PdfReport(string name, string content, double margin) : this(name, margin)
    {
        Content = content;
    }

    public void SetParser(ContentParser parser)
    {
        _parser = parser;
    }

    public string GenerateReport()
    {
        return _parser.Parse(Content);
    }
}