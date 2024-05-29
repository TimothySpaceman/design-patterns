using lab_5.Nodes;

namespace lab_5.Commands;

public class AddClassCommand : ICommand
{
    public LightElementNode Target;
    public string ClassName;

    public AddClassCommand(LightElementNode target, string className)
    {
        Target = target;
        ClassName = className;
    }
    
    public void Execute()
    {
        if (!Target.CssClasses.Contains(ClassName))
        {
            Target.CssClasses.Add(ClassName);
        }
    }

    public void Undo()
    {
        Target.CssClasses.Remove(ClassName);
    }
}