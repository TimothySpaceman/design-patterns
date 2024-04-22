namespace lab_3.Adapter;

public class FileWriter
{
    private string _filePath;

    public FileWriter(string filePath)
    {
        this._filePath = filePath;
    }

    public void Write(string message)
    {
        using StreamWriter sw = new(_filePath, true);
        sw.Write(message);
    }
    
    public void WriteLine(string message)
    {
        using StreamWriter sw = new(_filePath, true);
        sw.WriteLine(message);
    }
}