namespace lab_5.Nodes;

public class ExpandedState: INodeDisplayState
{
    public string InnerHTML(LightElementNode node, int childLevel)
    {
        return (node.IsInline ? "" : "\n") + (!node.IsPaired ? "" : node.Children.Aggregate("", (current, child) => current + child.OuterHTML(childLevel + 1) + (node.IsInline ? "" : "\n")));
    }
}