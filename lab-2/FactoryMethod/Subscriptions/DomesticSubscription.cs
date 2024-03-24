namespace lab_2.FactoryMethod;

public class DomesticSubscription : ISubscription
{
    public static double Price = 3.50;
    public static int MinPeriod = 1;
    public static List<Channel> Channels = Channel.DomesticChannels;

    public string Owner { get; }
    public DateTime Start { get; }
    public DateTime End { get; private set; }

    public DomesticSubscription(string owner, DateTime start, DateTime end)
    {
        if ((end - start).TotalDays / 30 < MinPeriod)
            throw new ArgumentException("Dates do not match minimum subscription period");
        Price = 3.50;
        MinPeriod = 1;
        Channels = Channel.DomesticChannels;
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
        return $"Domestic {(int)((End - Start).TotalDays / 30)} month subscrption for ${Price}";
    }
}