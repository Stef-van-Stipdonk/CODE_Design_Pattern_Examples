namespace Wk1;

public interface IPublisher
{
    void Subscribe(IObserver subscriber);
    
    void Unsubscribe(IObserver subscriber);
    
    void NotifySubscribers();

    void PublishNews();
}