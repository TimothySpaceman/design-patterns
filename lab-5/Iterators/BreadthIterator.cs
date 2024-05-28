using lab_5.Nodes;

namespace lab_5.Iterators;

public class BreadthIterator: INodeIterator
{
    public List<LightNode> Nodes = new List<LightNode>();
    public Queue<LightNode> Queue = new Queue<LightNode>();
    public int CurrentIndex = 0;

    public BreadthIterator(LightNode root)
    {
        Queue.Enqueue(root);
        AddChildNodes();
    }

    private void AddChildNodes()
    {
        var CurrentQueue = new Queue<LightNode>();
        while(Queue.Any())
        { 
            CurrentQueue.Enqueue(Queue.Dequeue());
        }
        while(CurrentQueue.Any())
        {
            var node = CurrentQueue.Dequeue();
            Nodes.Add(node);
            if (node is not LightElementNode elementNode) continue;
            foreach (var child in elementNode.Children)
            {
                Queue.Enqueue(child);
            }
        }

        if (Queue.Any())
        {
            AddChildNodes();
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