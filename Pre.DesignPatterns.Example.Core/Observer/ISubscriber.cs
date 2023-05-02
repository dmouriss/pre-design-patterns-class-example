namespace Pre.DesignPatterns.Example.Core.Observer;

public interface ISubscriber
{
    void Update(ISubject subject, Episode episode);
}