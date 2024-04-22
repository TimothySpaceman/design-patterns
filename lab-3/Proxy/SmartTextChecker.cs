namespace lab_3.Proxy;

public class SmartTextChecker : ITextReader
{
    public SmartTextChecker(ITextReader service)
    {
        Service = service;
    }

    public ITextReader? Service { get; set; }

    public char[][]? ReadFile(string filePath)
    {
        try
        {
            var data = Service.ReadFile(filePath);
            if (data != null)
            {   
                Console.WriteLine(
                $"File contains {data.Count()} lines with {data.Sum(line => line.Count())} chars in total");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return null;
    }
}