namespace lab_4.Strategy.ImageStrategy;

public class LoadWebStrategy : IStrategy
{
    public string Load(string href)
    {
        return $"{href} loaded from the web";
    }
}