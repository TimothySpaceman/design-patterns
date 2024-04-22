using System.Text.RegularExpressions;
using lab_3.Adapter;
using lab_3.Bridge;
using lab_3.Decorator;
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
