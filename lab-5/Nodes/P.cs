namespace lab_5.Nodes;

public class P : LightElementNode
{
    public P(List<string>? cssClasses = null, string text = "") : 
        base("p", true, true, cssClasses, new List<LightNode> { new LightTextNode(text) })
    {
    }

    public override string OuterHTML(int childLevel = 0)
    {
        var padding = new string(' ', childLevel * 4);
        
        var result = padding + $"<{Tag}";
        result += CssClasses.Count != 0 ? " class=\"" + string.Join(" ", CssClasses.ToArray()) + "\"" : "";
        result += ">";
        result += $"{InnerHTML(-1)}</{Tag}>";
        return result;
    }
}