using lab_5.Nodes;

namespace lab_5.Commands;

public class AppendCommand : ICommand
{
    public LightElementNode Target;
    public LightNode[] Items = {};

    public AppendCommand(LightElementNode target, params object[] items)
    {
        Target = target;
        foreach (var item in items)
        {
            if (item is LightNode)
            {
                Items = Items.Append((LightNode)item).ToArray();
            } else if (item is string)
            {
                Items = Items.Append(new LightTextNode((string)item)).ToArray();
            }
        }
    }
    
    public void Execute()
    {
        foreach (var item in Items)
        {
            Target.Children.Add(item);
            item.Parent = Target;
        }
    }

    public void Undo()
    {
        foreach (var item in Items)
        {
            Target.Children.Remove(item);
            item.Parent = null;
        }
    }
}