namespace lab_4.Strategy.ImageStrategy;

public class LoadLocalStrategy : IStrategy
{
    public string Load(string href)
    {
        return $"{href} loaded from the local drive";
    }
}