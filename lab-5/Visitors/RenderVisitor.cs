using lab_5.Nodes;
using lab_5.Styles;

namespace lab_5.Visitors;

public class RenderVisitor : IVisitor
{
    public StyleSheet StyleSheet;

    public RenderVisitor(StyleSheet styleSheet)
    {
        StyleSheet = styleSheet;
    }
    
    public void Visit(Body node)
    {
        var style = StyleSheet.GetStyleWithInheritance(node);
        Console.BackgroundColor = style.BackgroundColor ?? ConsoleColor.Black;
        for (var i = style.Top ?? 0; i < (style.Top ?? 0) + (style.Height ?? 0); i += 1)
        {
            Console.CursorTop = i;
            Console.CursorLeft = style.Left ?? 0;
            for (var j = 0; j < (style.Width ?? 0); j += 1)
            {
                Console.Write(" ");
            }   
        }
    }

    public void Visit(Div node)
    {
        var style = StyleSheet.GetStyleWithInheritance(node);
        Console.BackgroundColor = style.BackgroundColor ?? ConsoleColor.Black;
        for (var i = style.Top ?? 0; i < (style.Top ?? 0) + (style.Height ?? 0); i += 1)
        {
            Console.CursorTop = i;
            Console.CursorLeft = style.Left ?? 0;
            for (var j = 0; j < (style.Width ?? 0); j += 1)
            {
                Console.Write(" ");
            }   
        }
    }

    public void Visit(P node)
    {
        var style = StyleSheet.GetStyleWithInheritance(node);
        Console.BackgroundColor = style.BackgroundColor ?? ConsoleColor.Black;
        Console.ForegroundColor = style.ForegroundColor ?? ConsoleColor.White;
        Console.CursorTop = style.Top ?? 0;
        Console.CursorLeft = style.Left ?? 0;
        node.SetDisplayState(new ExpandedState());
        var parts = node.InnerHTML(-1).Split("\n");
        for (var i = 0; i < parts.Length; i += 1)
        {
            Console.CursorTop = style.Top ?? 0 + i;
            Console.CursorLeft = style.Left ?? 0;
            Console.Write(parts[i]);
        }
    }
   
    public void Visit(LightTextNode node)
    {
        var style = StyleSheet.GetStyleWithInheritance(node);
        Console.BackgroundColor = style.BackgroundColor ?? ConsoleColor.Black;
        Console.ForegroundColor = style.ForegroundColor ?? ConsoleColor.White;
        Console.CursorTop = style.Top ?? 0;
        Console.CursorLeft = style.Left ?? 0;
        var parts = node.InnerHTML().Split("\n");
        for (var i = 0; i < parts.Length; i += 1)
        {
            Console.CursorTop = style.Top ?? 0 + i;
            Console.CursorLeft = style.Left ?? 0;
            Console.Write(parts[i]);
        }
    }
    
    public void Visit(LightElementNode node)
    {
        if (node is Body)
        {
            Visit((Body)node);
        } else if (node is Div)
        {
            Visit((Div)node);
        } else if (node is P)
        {
            Visit((P)node);
        }
    }

    public void Visit(LightNode node)
    {
        if (node is LightElementNode)
        {
            Visit((LightElementNode)node);
        } else if (node is LightTextNode)
        {
            Visit((LightTextNode)node);
        }
    }
}