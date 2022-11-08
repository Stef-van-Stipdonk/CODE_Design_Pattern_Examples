namespace WK2___Factory.Creators;

public class BoatCreator : Creator
{
    protected override ITransport TransportCreation()
    {
        return new Boat();
    }
}