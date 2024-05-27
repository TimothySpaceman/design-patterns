// Chain of Responsibility
using lab_4.ChainOfResponsibility.Handlers;Console.WriteLine("Chain of Responsibility");

AbstractHandler[] handlers =
{
    new ConsultingHandler(),
    new FaqHandler(),
    new CustomersSupportHandler(),
    new TechSupportHandler()
};

for(var i = 0; i < handlers.Length - 1; i += 1){
    handlers[i].SetNextHandler(handlers[i + 1]);
}

handlers[0].Handle();



