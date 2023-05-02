// See https://aka.ms/new-console-template for more information


using Pre.DesignPatterns.Example.Core.ExpressionBuilder;

string template = "<city>, <date>\n\nBeste klant\nlorep ipsum\n\nMet vriendelijke groeten\nDieter";

ContentParser parser = new ContentParser();
parser.AddExpression(new DateExpression("<date>", "dddd dd MMMM yyyy"));
parser.AddExpression(new TextExpression("<city>", "Brugge"));

Console.WriteLine(parser.Parse(template));