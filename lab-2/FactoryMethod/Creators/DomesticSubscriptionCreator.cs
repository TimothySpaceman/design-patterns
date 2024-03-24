namespace lab_2.FactoryMethod;

public class DomesticSubscriptionCreator : ISubscriptionCreator
{
    public ISubscription CreateSubscription(string owner, DateTime start, DateTime end)
    {
        var subscription = new DomesticSubscription(owner, start, end);

        return subscription;
    }
}