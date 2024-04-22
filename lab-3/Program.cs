using lab_3.Adapter;

ILogger l = new Logger();
ILogger fl = new FileLogger();

l.Log("This one goes to CLI");
fl.Log("And this one will be in the file");
l.Warn("You should pay attention to this one");
fl.Warn("And this one looks quite important as well");
l.Error("Oops! Something bad here");
fl.Error("Fix it ASAP");
