using System.Text.RegularExpressions;
using lab_3.Adapter;
using lab_3.Bridge;
using lab_3.Composite;
using lab_3.Decorator;
using lab_3.Flyweight;
using lab_3.Proxy;

// Adatper
Console.WriteLine("Adapter");

ILogger l = new Logger();
ILogger fl = new FileLogger();

l.Log("This one goes to CLI");
fl.Log("And this one will be in the file");
l.Warn("You should pay attention to this one");
fl.Warn("And this one looks quite important as well");
l.Error("Oops! Something bad here");
fl.Error("Fix it ASAP");


// Decorator
Console.WriteLine();
Console.WriteLine("Decorator");

ICharacter father = new Father("Father");
father.Have(new Hug()).Have(new Love()).Have(new Kindness()).Have(new Warmth()).Have(new Softness());

ICharacter son = new Father("Son");

Console.WriteLine(father.Act(son));


// Bridge
Console.WriteLine();
Console.WriteLine("Bridge");

Shape triangle = new Triangle(-3,5,2,3,-2,-3);

VectorGraphicsEngine vectorEngine = new VectorGraphicsEngine(triangle);
BitmapGraphicsEngine bitmapEngine = new BitmapGraphicsEngine(triangle);

Console.WriteLine(vectorEngine.Render());
Console.WriteLine(bitmapEngine.Render());


// Proxy
Console.WriteLine();
Console.WriteLine("Proxy");

ITextReader textReader = new SmartTextReader();
ITextReader textReaderLocker = new SmartTextReaderLocker(textReader, "\\.dll$");
ITextReader textChecker = new SmartTextChecker(textReaderLocker);

textChecker.ReadFile("./log.txt");
textChecker.ReadFile("./lab-3.dll");


// Composite
Console.WriteLine();
Console.WriteLine("Composite");

var lis = new List<LightNode>
{
    new LightElementNode("li", false, true, null, new List<LightNode>{new LightTextNode("Adapter")}),
    new LightElementNode("li", false, true, null, new List<LightNode>{new LightTextNode("Decorator")}),
    new LightElementNode("li", false, true, null, new List<LightNode>{new LightTextNode("Bridge")}),
    new LightElementNode("li", false, true, null, new List<LightNode>{new LightTextNode("Proxy")}),
    new LightElementNode("li", false, true, new List<string>{"highlight"}, new List<LightNode>{new LightTextNode("Composite")}),
    new LightElementNode("li", false, true, null, new List<LightNode>{new LightTextNode("Flyweight")})
};
var ul = new LightElementNode("ul", false, true, new List<string>{"patterns-list"}, lis);
var title = new LightElementNode("h2", true, true, null, new List<LightNode>{new LightTextNode("Design Patterns")});
var image = new LightElementNode("img", false, false, new List<string>{"patterns-image"});
var div = new LightElementNode("div", false, true, new List<string>{"container", "bg-red"}, new List<LightNode>{image, title, ul});

Console.WriteLine(div.OuterHTML());


// Flyweight
Console.WriteLine();
Console.WriteLine("Flyweight");

var ramBefore = GC.GetTotalMemory(true);                                                  
var body = LightTextParser.ParseFile("book.txt");                                         
var ramAfter = GC.GetTotalMemory(true);                                                   
Console.WriteLine($"Memory consumed without Flyweight: {ramAfter - ramBefore} bytes"); //≈1570 kilobytes    

var ramBeforeFlyweight = GC.GetTotalMemory(true);
var flyweightBody = LightFlyweightTextParser.ParseFile("book.txt");
var ramAfterFlyweight = GC.GetTotalMemory(true);
Console.WriteLine($"Memory consumed with Flyweight: {ramAfterFlyweight - ramBeforeFlyweight} bytes"); //≈1530 kilobytes