namespace lab_2.FactoryMethod;

public interface ISubscription
{
    public static double Price { get; }
    public static int MinPeriod { get; }
    public static List<Channel> Channels { get; }
    public string Owner { get; }
    public DateTime Start { get; }
    public DateTime End { get; }

    public void Extend(int period);
}