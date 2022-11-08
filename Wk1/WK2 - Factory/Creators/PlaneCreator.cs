namespace WK2___Factory.Creators;

public class PlaneCreator : Creator
{
    protected override ITransport TransportCreation()
    {
        return new Plane();
    }
}