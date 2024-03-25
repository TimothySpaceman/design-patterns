using lab_2.FactoryMethod;
using lab_1.AbstractFactory;

//Factory Method
Console.WriteLine("Factory method");
var managerCall = new ManagerCall();
Console.WriteLine(managerCall.GetBestSubscription("Tim",DateTime.Now, 100.00));

//Abstract Factory
Console.WriteLine();
Console.WriteLine("Abstract Factory");
IAbstractFactory samsungFactory = new SamsungFactory();
IAbstractFactory appleFactory = new AppleFactory();

IMonitor samsungMonitor = samsungFactory.CreateMonitor(23, "IPS", 60, (3840, 2160), false);
IMonitor appleMonitor = appleFactory.CreateMonitor(32, "Retina", 60, (6016, 3384), true);

Console.WriteLine(samsungMonitor);
Console.WriteLine(appleMonitor);

//Singleton
Console.WriteLine();


Console.ReadLine();