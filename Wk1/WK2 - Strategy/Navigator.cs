namespace WK2___Strategy;

public class Navigator
{
    private IStrategy Strategy { get; set; }

    public void SetStrategy(IStrategy strategy)
    {
        Strategy = strategy;
    }

    public void Navigate()
    {
        Strategy.Execute();
    }
}