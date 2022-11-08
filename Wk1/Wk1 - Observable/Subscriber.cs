namespace Wk1;

public class Subscriber : IObserver
{
    public void Update(Publisher publisher)
    {
        Console.WriteLine("Subscriber reacted to published news");
    }
}