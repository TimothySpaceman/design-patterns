using lab_3.Composite;

namespace lab_3.Flyweight;

public class LightFlyweightElementNode : LightNode
{
    public NodeType NodeType;
    public List<string> CssClasses { get; }
    public List<LightNode> Children { get; }
    
    public int ChildrenCount => Children.Count;
    
    public override string InnerHTML(int childLevel = 0)
    {
        return !NodeType.IsPaired ? "" : Children.Aggregate("", (current, child) => current + child.OuterHTML(childLevel + 1) + "\n");
    }

    public override string OuterHTML(int childLevel = 0)
    {
        var padding = new string(' ', childLevel * 4);
        
        var result = padding + $"<{NodeType.Tag}";
        result += CssClasses.Count != 0 ? " class=\"" + string.Join(" ", CssClasses.ToArray()) + "\"" : "";
        result += NodeType.IsPaired ? ">" : "/>";
        if(!NodeType.IsPaired) return result;
        
        result += "\n" + InnerHTML(childLevel);
        result += NodeType.IsPaired ? $"{padding}</{NodeType.Tag}>" : "";
        return result;
    }

    public LightFlyweightElementNode(string tag, bool isInline = true, bool isPaired = false, List<string>? cssClasses = null, List<LightNode>? children = null)
    {
        NodeType = NodeTypeFactory.GetInstance().GetNodeType(tag, isInline, isPaired);
        CssClasses = cssClasses ?? new List<string>();
        Children = children ?? new List<LightNode>();
    }
}