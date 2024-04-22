namespace lab_3.Proxy;

public interface ITextReader
{
    public ITextReader? Service { get; set; }
    public char[][]? ReadFile(string filePath);
}