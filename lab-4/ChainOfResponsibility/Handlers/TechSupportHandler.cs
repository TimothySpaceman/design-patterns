using lab_4.ChainOfResponsibility.Services;

namespace lab_4.ChainOfResponsibility.Handlers;

public class TechSupportHandler : AbstractHandler
{
    public override void Handle()
    {
        var service = new TechSupportService();
        service.Serve();
    }
}