namespace lab_2.FactoryMethod;

public class PremiumSubscriptionCreator : ISubscriptionCreator
{
    public ISubscription CreateSubscription(string owner, DateTime start, DateTime end)
    {
        var subscription = new PremiumSubscription(owner, start, end);

        return subscription;
    }
}