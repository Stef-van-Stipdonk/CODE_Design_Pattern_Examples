namespace Wk1;

public class Publisher : IPublisher
{
    private List<IObserver> _subscribers { get; }

    public Publisher()
    {
        _subscribers = new List<IObserver>();
    }
    
    public void Subscribe(IObserver subscriber)
    {
        _subscribers.Add(subscriber);
    }

    public void Unsubscribe(IObserver subscriber)
    {
        _subscribers.Remove(subscriber);
    }

    public void NotifySubscribers()
    {
        _subscribers.ForEach(s => s.Update(this));
    }

    public void PublishNews()
    {
        Console.WriteLine("Create news");
        Console.WriteLine("Notify subscribers");
        NotifySubscribers();
    }
}