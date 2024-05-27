namespace lab_4.ChainOfResponsibility.Services;

public class TechSupportService : ISupportService
{
    public void Serve()
    {
        Console.WriteLine("Dealing with customer's technical problems...");
    }
}