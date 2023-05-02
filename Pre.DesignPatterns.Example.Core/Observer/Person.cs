namespace Pre.DesignPatterns.Example.Core.Observer;

public class Person : ISubscriber
{
    public string Name { get; set; }

    public void SendMessage(Episode episode)
    {
        Console.WriteLine($"A new episode was added {episode.Name}");
    }
    
    public void Update(ISubject subject, Episode episode)
    {
        SendMessage(episode);
    }
}