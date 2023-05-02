namespace Pre.DesignPatterns.Example.Core.Animals.Inheritance;

public class Dog : Animal
{
    public string Owner { get; set; }

    public override void Eat()
    {
        base.Eat();
        Console.WriteLine("The dog ate");
    }

    public void Bark()
    {
        Console.WriteLine("Bark!");
    }
}