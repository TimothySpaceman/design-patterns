using lab_3.Composite;

namespace lab_3.Flyweight;

public class LightFlyweightTextParser
{
    public static LightNode ParseFile(string filePath)
    {
        var result = new LightFlyweightElementNode("body", false, true, null, null);
        
        using var file = new StreamReader(filePath);

        string? line;
        while ((line = file.ReadLine()) != null)
        {
            var text = new LightTextNode(line);
            LightFlyweightElementNode node;

            if (result.Children.Count == 0)
            {
                node = new LightFlyweightElementNode("h1", true, true, null, null);
            } else if (line.StartsWith(' '))
            {
                node = new LightFlyweightElementNode("blockquote", true, true, null, null);
            } else if (line.Length < 20)
            {
                node = new LightFlyweightElementNode("h2", true, true, null, null);
            }
            else
            {
                node = new LightFlyweightElementNode("p", true, true, null, null);
            }
            
            node.Children.Add(text);
            result.Children.Add(node);
        }

        return result;
    }
}