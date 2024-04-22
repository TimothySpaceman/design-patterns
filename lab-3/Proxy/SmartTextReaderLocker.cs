using System.Text.RegularExpressions;

namespace lab_3.Proxy;

public class SmartTextReaderLocker : ITextReader
{
    public SmartTextReaderLocker(ITextReader service, string accessRegex = null)
    {
        Service = service;
        AccessRegex = accessRegex;
    }

    public string AccessRegex { get; set; }

    public ITextReader? Service { get; set; }

    public char[][]? ReadFile(string filePath)
    {
        if (AccessRegex != "" && Regex.IsMatch(filePath, AccessRegex ?? "")) throw new Exception("Access denied!");

        char[][]? data = null;
        try
        {
            data = Service.ReadFile(filePath);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return data;
    }
}