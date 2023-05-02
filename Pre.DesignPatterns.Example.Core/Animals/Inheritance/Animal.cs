namespace Pre.DesignPatterns.Example.Core.Animals.Inheritance;

public class Animal
{
    public string Color { get; set; }

    public virtual void Eat()
    {
        Console.WriteLine("processing food");
    }
}