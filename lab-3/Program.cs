using lab_3.Adapter;
using lab_3.Decorator;

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