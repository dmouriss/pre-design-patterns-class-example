namespace Pre.DesignPatterns.Example.Core.Animals.Composition;

public class Lion
{
    private Animal _animal;
    
    public string JungleName { get; set; }

    public string Color
    {
        get => _animal.Color;

        set => _animal.Color = value;
    }

    public void Eat()
    {
        _animal.Eat();
        Console.WriteLine("The lion ate");
    }

    public void Roar()
    {
        Console.WriteLine("Roar!");
    }
}