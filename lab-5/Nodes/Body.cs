namespace lab_5.Nodes;

public class Body : LightElementNode
{
    public Body(List<string>? cssClasses = null, List<LightNode>? children = null) : base("body", false, true, cssClasses, children)
    {
    }
}