using System.Runtime.Loader;
using lab_5.Nodes;

namespace lab_5.Styles;

public class StyleSheet
{
    public Dictionary<string, Style> Classes = new Dictionary<string, Style>();

    public StyleSheet AddClass(string className, Style style)
    {
        Classes[className] = style;
        return this;
    }

    public Style GetStyle(LightNode node)
    {
        var result = new Style();
        if (node is LightTextNode)
        {
            return result;
        }

        var elementNode = (LightElementNode)node;
        foreach (var className in elementNode.CssClasses.Where(className => Classes.ContainsKey(className)))
        {
            result.Merge(Classes[className]);
        }
        return result;
    }

    public Style GetStyleWithInheritance(LightNode node)
    {
        var result = new Style();
        var currentNode = node;
        while (currentNode != null)
        {
            result.Merge(GetStyle(currentNode));
            currentNode = currentNode.Parent;
        }
        result.Merge(Style.Defaults);
        return result;
    }
}