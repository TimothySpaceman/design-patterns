using lab_4.ChainOfResponsibility.Services;

namespace lab_4.ChainOfResponsibility.Handlers;

public class CustomersSupportHandler : AbstractHandler
{
    public override void Handle()
    {
        var isHandled = false;
        while (!isHandled)
        {
            isHandled = AskForServing("Do you have any non-technical questions?", new CustomersSupportService());   
        }
    }
}