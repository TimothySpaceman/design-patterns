namespace lab_4.ChainOfResponsibility.Services;

public class FaqService : ISupportService
{
    public void Serve()
    {
        Console.WriteLine("Answering customer's questions with answers from FAQ database...");
    }
}