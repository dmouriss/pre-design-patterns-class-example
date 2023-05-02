namespace Pre.DesignPatterns.Example.Core.Animals.Inheritance;

public class Lion : Animal
{
    public string JungleName { get; set; }

    public override void Eat()
    {
        base.Eat();
        Console.WriteLine("The lion ate");
    }

    public void Roar()
    {
        Console.WriteLine("Roar!");
    }
}