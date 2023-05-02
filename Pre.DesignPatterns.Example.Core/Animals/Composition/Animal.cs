namespace Pre.DesignPatterns.Example.Core.Animals.Composition;

public class Animal
{
    public string Color { get; set; }

    public void Eat()
    {
        Console.WriteLine("Processing food");
    }
}