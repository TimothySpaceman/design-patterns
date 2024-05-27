using lab_4.ChainOfResponsibility.Handlers;
using lab_4.Mediator;
using lab_4.Observer;
using lab_4.Strategy.ImageStrategy;
using lab_4.Strategy.Nodes;

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


// Observer 
Console.WriteLine("Observer");

var label = new LightElementNode("label", false, true, new List<string>{"pretty-label"}, new List<LightNode> { new LightTextNode("Click me!") });
var labelDiv = new LightElementNode("div", false, true, new List<string>{"container", "bg-red"}, new List<LightNode>{label});
var body = new LightElementNode("body", false, true, null, new List<LightNode>{labelDiv});

void LabelClick(Event eventInstance)
{
    var e = (ClickEvent)eventInstance;
    Console.WriteLine($"Label clicked with button {e.Button} at ({e.Position.Item1}, {e.Position.Item2})");
}

void DivClick(Event eventInstance)
{
    var e = (ClickEvent)eventInstance;
    Console.WriteLine($"Div clicked with button {e.Button} at ({e.Position.Item1}, {e.Position.Item2})");
    Console.WriteLine($"Received from {e.Target.Tag} tag");
}

label.AddListener("click", LabelClick);
labelDiv.AddListener("click", DivClick);

Console.WriteLine(body.OuterHTML());

labelDiv.OnClick((4, 12), 0);
label.OnClick((15, 21), 0);


// Strategy 
Console.WriteLine("Strategy");

var imgLocal = new Img("../assets/strategy.png");
var imgWeb = new Img("https://images.com/strategy.png");

var imgDiv = new lab_4.Strategy.LightElementNode("div", false, true, null, new List<lab_4.Strategy.LightNode>{imgLocal, imgWeb});
Console.WriteLine(imgDiv.OuterHTML());