namespace lab_2.FactoryMethod;

public class MobileApp
{
    public SubscriptionCreator Creator = new();

    public void ChooseSubscription(string subscription)
    {
        Creator.SelectSubscription(subscription);
    }

    public ISubscription Subscribe(string owner, DateTime start, DateTime end)
    {
        if (Creator.SelectedSubscription == null)
            throw new Exception("Subscription type is not selected");

        return Creator.CreateSubscription(owner, start, end);
    }
}