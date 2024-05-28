using lab_5.Nodes;

namespace lab_5.Iterators;

public class DepthIterator: INodeIterator
{
    public List<LightNode> Nodes = new List<LightNode>();
    public int CurrentIndex = 0;

    public DepthIterator(LightNode root)
    {
        AddChildNodes(root);
    }

    public void AddChildNodes(LightNode node)
    {
        Nodes.Add(node);
        if (node is not LightElementNode) return;
        foreach (var child in ((LightElementNode)node).Children)
        {
            AddChildNodes(child);
        }
    }

    public bool HasMore()
    {
        return CurrentIndex < Nodes.Count - 1;
    }

    public LightNode? Next()
    {
        if (!HasMore())
        {
            return null;
        }

        return Nodes[CurrentIndex++];
    }
}