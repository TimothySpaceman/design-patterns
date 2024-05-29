using lab_5.Nodes;

namespace lab_5.Commands;

public class RemoveClassCommand : ICommand
{
    public LightElementNode Target;
    public string ClassName;

    public RemoveClassCommand(LightElementNode target, string className)
    {
        Target = target;
        ClassName = className;
    }
    
    public void Execute()
    {
        Target.CssClasses.Remove(ClassName);
    }

    public void Undo()
    {
        if (!Target.CssClasses.Contains(ClassName))
        {
            Target.CssClasses.Add(ClassName);
        }
    }
}