namespace WK2___Factory.Creators;

public class CarCreator : Creator
{
    protected override ITransport TransportCreation()
    {
        return new Car();
    }
}