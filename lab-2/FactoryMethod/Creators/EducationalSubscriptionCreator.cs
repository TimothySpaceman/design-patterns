namespace lab_2.FactoryMethod;

public class EducationalSubscriptionCreator : ISubscriptionCreator
{
    public ISubscription CreateSubscription(string owner, DateTime start, DateTime end)
    {
        var subscription = new EducationalSubscription(owner, start, end);

        return subscription;
    }
}