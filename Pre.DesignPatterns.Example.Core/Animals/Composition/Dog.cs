namespace Pre.DesignPatterns.Example.Core.Animals.Composition;

public class Dog
{
    private Animal _animal = new Animal();

    public string Color
    {
        get
        {
            return _animal.Color;
        }

        set
        {
            _animal.Color = value;
        }
    }
    
    public string Owner { get; set; }

    public void Eat()
    {
        _animal.Eat();
        Console.WriteLine("The dog ate");
    }

    public void Bark()
    {
        Console.WriteLine("Bark!");
    }
}