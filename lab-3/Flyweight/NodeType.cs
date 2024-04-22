namespace lab_3.Flyweight;

public class NodeType
{
    public string Tag { get; }
    public bool IsInline { get; }
    public bool IsPaired { get; }

    public NodeType(string tag = "", bool isInline = true, bool isPaired = true)
    {
        Tag = tag;
        IsInline = isInline;
        IsPaired = isPaired;
    }

    public override bool Equals(object? obj)
    {
        if (obj is not NodeType) return false;
    
        var nt = (NodeType)obj;
        return Tag == nt.Tag && IsInline == nt.IsInline && IsPaired == nt.IsPaired;
    }
}