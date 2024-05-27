namespace lab_4.Observer;

public class LightTextNode: LightNode
{
    private string _content;

    public LightTextNode(string content = "")
    {
        _content = content;
    }

    public override string InnerHTML(int childLevel = 0)
    {
        return new string(' ', childLevel * 4) + _content;
    }

    public override string OuterHTML(int childLevel = 0)
    {
        return new string(' ', childLevel * 4) + _content;
    }
}