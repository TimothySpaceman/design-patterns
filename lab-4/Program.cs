using lab_4.ChainOfResponsibility.Handlers;
using lab_4.Mediator;

// Chain of Responsibility
Console.WriteLine("Chain of Responsibility");

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


// Mediator 
Console.WriteLine("Mediator");

var commandCentre = new CommandCentre();
var a1 = new Aircraft("F-22", commandCentre);
var a2 = new Aircraft("F-16", commandCentre);
var a3 = new Aircraft("F-18", commandCentre);
var r1 = new Runway(commandCentre);
var r2 = new Runway(commandCentre);

a1.Land();
a2.Land();
a1.Land();
a3.Land();
a2.TakeOff();
a3.Land();
