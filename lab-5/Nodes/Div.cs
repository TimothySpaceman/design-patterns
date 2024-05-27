namespace lab_5.Nodes;

public class Div : LightElementNode
{
    
    public Div(List<string>? cssClasses = null, List<LightNode>? children = null) : base("div", false, true, cssClasses, children)
    {
    }
}