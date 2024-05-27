namespace lab_4.ChainOfResponsibility.Services;

public class ConsultingService : ISupportService
{
    public void Serve()
    {
        Console.WriteLine("Consulting the customer about products and offers...");
    }
}