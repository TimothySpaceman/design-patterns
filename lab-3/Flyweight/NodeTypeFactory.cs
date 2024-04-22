namespace lab_3.Flyweight;

public class NodeTypeFactory
{
    private static Lazy<NodeTypeFactory> _lazy = new(() => new NodeTypeFactory());

    public static NodeTypeFactory GetInstance() => _lazy.Value;

    private List<NodeType> _nodeTypes;

    public NodeTypeFactory()
    {
        _nodeTypes = new List<NodeType>();
    }

    public NodeType GetNodeType(string tag, bool isInline, bool isPaired)
    {
        var newNodeType = new NodeType(tag, isInline, isPaired);
        var storedEquivalent = _nodeTypes.Find((node)=>newNodeType.Equals(node));
        if (storedEquivalent != null) return storedEquivalent;
        
        _nodeTypes.Add(newNodeType);
        return newNodeType;
    }
}