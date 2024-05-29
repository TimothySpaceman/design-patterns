using lab_5.Iterators;
using lab_5.Styles;
using lab_5.Visitors;

namespace lab_5.Nodes;

public class Document
{
    public Body Body;
    public StyleSheet StyleSheet;

    public Document(Body body, StyleSheet styleSheet)
    {
        Body = body;
        StyleSheet = styleSheet;
    }

    public void Render()
    {
        var iterator = new DepthIterator(Body);
        var visitor = new RenderVisitor(StyleSheet);
        var node = iterator.Next();
        while (node != null)
        {
            visitor.Visit(node);
            node = iterator.Next();
        }
    }
}