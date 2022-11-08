namespace WK2___Factory;

public abstract class Creator
{
    protected abstract ITransport TransportCreation();

    public string ExecuteOperation()
    {
        var product = TransportCreation();

        return $"Method of transportation{product.Transport()}";
    }
}