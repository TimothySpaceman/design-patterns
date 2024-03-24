namespace lab_2.FactoryMethod;

public class PremiumSubscription : ISubscription
{
    public static double Price = 6.25;
    public static int MinPeriod = 1;
    public static List<Channel> Channels = Channel.PremiumCHannels;

    public string Owner { get; }
    public DateTime Start { get; }
    public DateTime End { get; private set; }

    public PremiumSubscription(string owner, DateTime start, DateTime end)
    {
        if ((end - start).TotalDays / 30 < MinPeriod)
            throw new ArgumentException("Dates do not match minimum subscription period");
        Owner = owner;
        Start = start;
        End = end;
    }

    public void Extend(int period)
    {
        if (period <= 0) throw new ArgumentException("Period must be greater than 0");
        End = End.AddMonths(period);
    }

    public override string ToString()
    {
        return $"Premium {(int)((End - Start).TotalDays / 30)} month subscrption for ${Price}";
    }
}