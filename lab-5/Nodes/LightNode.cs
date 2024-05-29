namespace lab_5.Nodes;

public class LightNode
{
    public LightElementNode? Parent = null;
    
    public virtual string InnerHTML(int childLevel = 0)
    {
        return "";
    }
    
    public virtual string OuterHTML(int childLevel = 0)
    {
        return "";
    }
}