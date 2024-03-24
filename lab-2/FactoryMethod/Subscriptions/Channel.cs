namespace lab_2.FactoryMethod;

public class Channel
{
    //Just for the demo!
    public static List<Channel> DomesticChannels = new()
    {
        new Channel("News Channel", "news.png"),
        new Channel("Cooking Channel", "cooking.png"),
        new Channel("Sports Channel", "sports.png")
    };

    public static List<Channel> EducationalChannels = new()
    {
        new Channel("Discovery Channel", "discovery.png"),
        new Channel("Documentary Channel", "travel.png"),
        new Channel("Tech Channel", "comedy.png"),
        new Channel("Science Channel", "science.png"),
        new Channel("History Channel", "nature.png")
    };

    public static List<Channel> PremiumCHannels = new()
    {
        new Channel("History Channel", "history.png"),
        new Channel("Music Channel", "music.png"),
        new Channel("Movie Channel", "movies.png"),
        new Channel("Documentary Channel", "documentary.png"),
        new Channel("Health Channel", "health.png"),
        new Channel("Fashion Channel", "fashion.png"),
        new Channel("Tech Channel", "tech.png"),
        new Channel("Gaming Channel", "gaming.png"),
        new Channel("Kids Channel", "kids.png"),
        new Channel("Food Channel", "food.png")
    };

    public Channel(string title, string imagePath)
    {
        Title = title;
        ImagePath = imagePath;
    }

    public string Title { get; private set; }
    public string ImagePath { get; private set; }
}