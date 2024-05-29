using lab_5.Nodes;

namespace lab_5.Commands;

public class ToggleClassCommand : ICommand
{
    public LightElementNode Target;
    public string ClassName;
    public bool IsNew = false;

    public ToggleClassCommand(LightElementNode target, string className)
    {
        Target = target;
        ClassName = className;
        IsNew = !Target.CssClasses.Contains(ClassName);
    }
    
    public void Execute()
    {
        ToggleClass();
    }

    public void Undo()
    {
        ToggleClass();
    }

    public void ToggleClass()
    {
        if (IsNew && !Target.CssClasses.Contains(ClassName))
        {
            Target.CssClasses.Add(ClassName);
        }
        else
        {
            Target.CssClasses.Remove(ClassName);
        }
    }
}