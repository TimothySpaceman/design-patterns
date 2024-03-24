namespace lab_2.FactoryMethod;

public class EducationalSubscription : ISubscription
{
    public static double Price = 2.00;
    public static int MinPeriod = 3;
    public static List<Channel> Channels = Channel.EducationalChannels;

    public string Owner { get; }
    public DateTime Start { get; }
    public DateTime End { get; private set; }

    public EducationalSubscription(string owner, DateTime start, DateTime end)
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
        return $"Educational {(int)((End - Start).TotalDays / 30)} month subscrption for ${Price}";
    }
}