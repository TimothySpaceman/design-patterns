namespace lab_2.FactoryMethod;

public class WebSite
{
    public ISubscription CreateDomesticSUbscription(string owner, DateTime start, int period)
    {
        var creator = new DomesticSubscriptionCreator();
        return creator.CreateSubscription(owner, start, start.AddMonths(period));
    }

    public ISubscription CreateEducationalSUbscription(string owner, DateTime start, int period)
    {
        var creator = new EducationalSubscriptionCreator();
        return creator.CreateSubscription(owner, start, start.AddMonths(period));
    }

    public ISubscription CreatePremiumSUbscription(string owner, DateTime start, int period)
    {
        var creator = new PremiumSubscriptionCreator();
        return creator.CreateSubscription(owner, start, start.AddMonths(period));
    }
}