using lab_3.Composite;

namespace lab_3.Flyweight;

public class LightTextParser
{
    public static LightNode ParseFile(string filePath)
    {
        var result = new LightElementNode("body", false, true, null, null);
        
        using var file = new StreamReader(filePath);

        string? line;
        while ((line = file.ReadLine()) != null)
        {
            var text = new LightTextNode(line);
            LightElementNode node;

            if (result.Children.Count == 0)
            {
                node = new LightElementNode("h1", true, true, null, null);
            } else if (line.StartsWith(' '))
            {
                node = new LightElementNode("blockquote", true, true, null, null);
            } else if (line.Length < 20)
            {
                node = new LightElementNode("h2", true, true, null, null);
            }
            else
            {
                node = new LightElementNode("p", true, true, null, null);
            }
            
            node.Children.Add(text);
            result.Children.Add(node);
        }

        return result;
    }
}