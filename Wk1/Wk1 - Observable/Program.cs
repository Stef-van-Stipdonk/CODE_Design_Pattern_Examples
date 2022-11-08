// See https://aka.ms/new-console-template for more information

using Wk1;

IPublisher publisher = new Publisher();

var subscriber1 = new Subscriber();
publisher.Subscribe(subscriber1);

var subscriber2 = new Subscriber();
publisher.Subscribe(subscriber2);

publisher.NotifySubscribers();
Console.WriteLine("\n--------------------\n");

publisher.Unsubscribe(subscriber1);

publisher.NotifySubscribers();