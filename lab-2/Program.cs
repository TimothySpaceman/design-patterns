using lab_2.FactoryMethod;
using lab_1.AbstractFactory;
using lab_1.Singleton;

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
Console.WriteLine("Singleton");

var authA = Authenticator.GetInstance();
var authB = Authenticator.GetInstance();

var thread = new Thread(() =>
{
    var authC = Authenticator.GetInstance();
    Console.WriteLine("Instance A " + (authA==authC ? "==" : "!=") +" Instance C");
});
Console.WriteLine("Instance A " + (authA==authB ? "==" : "!=") +" Instance B");
thread.Start();

Console.ReadLine();