namespace lab_3.Proxy;

public class SmartTextReader : ITextReader
{
    public SmartTextReader(ITextReader? service = null)
    {
        Service = service;
    }

    public ITextReader? Service { get; set; }

    public char[][]? ReadFile(string filePath)
    {
        var result = new List<char[]>();

        using var file = new StreamReader(filePath);

        string? line;
        while ((line = file.ReadLine()) != null) result.Add(line.ToCharArray());

        file.Close();

        return result.ToArray();
    }
}