using lab_5.Nodes;

namespace lab_5.Visitors;

public interface IVisitor
{
    public void Visit(Body node);
    public void Visit(Div node);
    public void Visit(P node);
    public void Visit(LightElementNode node);
    public void Visit(LightTextNode node);
    public void Visit(LightNode node);
}