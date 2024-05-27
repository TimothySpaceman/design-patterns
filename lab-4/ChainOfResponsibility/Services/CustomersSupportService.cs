namespace lab_4.ChainOfResponsibility.Services;

public class CustomersSupportService : ISupportService
{
    public void Serve()
    {
        Console.WriteLine("Dealing with customer's non-technical problems...");
    }
}