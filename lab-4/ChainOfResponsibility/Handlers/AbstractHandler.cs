using lab_4.ChainOfResponsibility.Services;

namespace lab_4.ChainOfResponsibility.Handlers;

public abstract class AbstractHandler
{
    public AbstractHandler? NextHandler;

    public abstract void Handle();

    public void SetNextHandler(AbstractHandler nextHandler)
    {
        NextHandler = nextHandler;
    }

    // Boilerplate construction extracted into this method 
    public bool AskForServing(string message, ISupportService service)
    {
        Console.WriteLine(message);
        Console.Write("1 - Yes\n2 - No\n=> ");
        var answer = Console.ReadKey().Key;
        Console.WriteLine();
        switch (answer)
        {
            case ConsoleKey.D1 or ConsoleKey.NumPad1:
            {
                service.Serve();
                return true;
            }
            case ConsoleKey.D2 or ConsoleKey.NumPad2:
                NextHandler?.Handle();
                return true;
            default:
                Console.WriteLine("Invalid option. Please, be careful and try again");
                return false;
        }
    }
}