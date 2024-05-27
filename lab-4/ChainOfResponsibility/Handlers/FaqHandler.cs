using lab_4.ChainOfResponsibility.Services;

namespace lab_4.ChainOfResponsibility.Handlers;

public class FaqHandler : AbstractHandler
{
    public override void Handle()
    {
        var isHandled = false;
        while (!isHandled)
        {
            isHandled = AskForServing("Do you want to search for the answer in our FAQ's?", new FaqService());   
        }
    }
}