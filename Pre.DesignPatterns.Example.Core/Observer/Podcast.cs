namespace Pre.DesignPatterns.Example.Core.Observer;

public class Podcast : ISubject
{
    private ICollection<ISubscriber> _subscribers;
    public string Title { get; }
    public ICollection<Episode> Episodes { get; }

    public Podcast(string title)
    {
        _subscribers = new List<ISubscriber>();
        Episodes = new List<Episode>();
        Title = title;
    }

    public Podcast(string title, ICollection<Person> subscribers) : this(title)
    {
        foreach (Person subscriber in subscribers)
        {
            AddSubscriber(subscriber);
        }
    }

    public void AddSubscriber(ISubscriber subscriber)
    {
        _subscribers.Add(subscriber);
    }

    public void RemoveSubscriber(ISubscriber subscriber)
    {
        _subscribers.Remove(subscriber);
    }

    public void Notify()
    {
        Notify(null);
    }

    public void Notify(Episode episode)
    {
        foreach (ISubscriber subscriber in _subscribers)
        {
            subscriber.Update(this, episode);
        }
    }
}