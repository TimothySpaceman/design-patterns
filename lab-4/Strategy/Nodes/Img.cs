using lab_4.Strategy.ImageStrategy;

namespace lab_4.Strategy.Nodes;

public class Img : LightElementNode
{
    public string Href;
    public IStrategy LoadingStrategy;
    
    public Img(string href, List<string>? cssClasses = null) : base("img", false, false, cssClasses, new List<LightNode>())
    {
        Href = href;
        LoadingStrategy = (href.StartsWith("http://") || href.StartsWith("https://")) ? new LoadWebStrategy() : new LoadLocalStrategy();
    }

    public override string OuterHTML(int childLevel = 0)
    {
        return $"{base.OuterHTML(childLevel)} ({LoadingStrategy.Load(Href)})";
    }
}