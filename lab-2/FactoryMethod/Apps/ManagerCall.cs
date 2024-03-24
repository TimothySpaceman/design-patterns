namespace lab_2.FactoryMethod;

public class ManagerCall
{
    public ISubscription GetBestSubscription(string owner, DateTime start, double budget)
    {
        if (budget < 3.50)
            throw new Exception("You are poor :(");

        ISubscriptionCreator? creator = null;

        if (budget is >= 3.50 and < 6.25)
        {
            creator = new DomesticSubscriptionCreator();
            return creator.CreateSubscription(owner, start, start.AddMonths(1));
        }

        creator = new PremiumSubscriptionCreator();
        return creator.CreateSubscription(owner, start, start.AddMonths((int)(budget / 6.25)));
    }

    public ISubscription GetEducationalSubscription(string owner, DateTime start, int period)
    {
        var creator = new EducationalSubscriptionCreator();
        return creator.CreateSubscription(owner, start, start.AddMonths(period));
    }
}