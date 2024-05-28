using lab_5.Nodes;

namespace lab_5.Iterators;

public interface INodeIterator
{
    public bool HasMore();
    public LightNode ? Next();
}