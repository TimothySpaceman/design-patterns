namespace lab_3.Adapter;

public class FileLogger : ILogger
{
    private FileWriter _fw;
    
    public FileLogger(string filePath = "./log.txt")
    {
        _fw = new FileWriter(filePath);
    }
    
    public void Log(string message)
    {
        _fw.WriteLine($"[{DateTime.Now:ss:mm:HH dd.MM.yyyy}] {message}");
    }
    
    public void Error(string message)
    {
        _fw.WriteLine($"ERROR: {message}");
    }
    
    public void Warn(string message)
    {
        _fw.WriteLine($"WARNING: {message}");
    }
}