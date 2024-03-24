namespace lab_2.FactoryMethod;

public class SubscriptionCreator : ISubscriptionCreator
{
    public static string[] Subscriptions = { "Domestic", "Educational", "Premium" };
    public string SelectedSubscription { get; private set; }

    public ISubscription CreateSubscription(string owner, DateTime start, DateTime end)
    {
        return SelectedSubscription switch
        {
            "Domestic" => new DomesticSubscription(owner, start, end),
            "Educational" => new EducationalSubscription(owner, start, end),
            "Premium" => new PremiumSubscription(owner, start, end),
            _ => throw new Exception("Invalid subscription type selected: " + SelectedSubscription)
        };
    }

    public void SelectSubscription(string subscription)
    {
        if (!Array.Exists(Subscriptions, s => s == subscription))
            throw new ArgumentException("Unknown subscription type: " + subscription);

        SelectedSubscription = subscription;
    }
}