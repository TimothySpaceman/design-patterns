using lab_4.ChainOfResponsibility.Services;

namespace lab_4.ChainOfResponsibility.Handlers;

public class ConsultingHandler : AbstractHandler
{
    public override void Handle()
    {
        var isHandled = false;
        while (!isHandled)
        {
            isHandled = AskForServing("Do you have any questions about our products and offers?", new ConsultingService());
        }
    }
}