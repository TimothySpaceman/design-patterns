namespace lab_2.FactoryMethod;

public interface ISubscriptionCreator
{
    public ISubscription CreateSubscription(string owner, DateTime start, DateTime end);
}