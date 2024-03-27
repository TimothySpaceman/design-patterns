using lab_2.FactoryMethod;
using lab_2.AbstractFactory;
using lab_2.Prototype;
using lab_2.Singleton;


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


//Prototype
Console.WriteLine();
Console.WriteLine("Prototype");

var abc1 = new Virus(1.75, 4, "Andrew", "ABC");
var abc2 = new Virus(3.15, 2, "Chris", "ABC");
var abc3 = new Virus(4.22, 1, "Robert", "ABC");
var abc4 = new Virus(2.90, 3, "Sebastian", "ABC");
var ab1 = new Virus(3.5, 3, "Michael", "AB", new List<IPrototype> {abc1, abc2, abc3});
var ab2 = new Virus(2.17, 2, "Adolf", "AB");
var ab3 = new Virus(1.61, 2, "Rudolf", "AB", new List<IPrototype> {abc4});
var a1 = new Virus(1.32, 1, "John", "A", new List<IPrototype> {ab1, ab2, ab3});
var a2 = (Virus)a1.Clone();

Console.WriteLine("a1: \n" + a1.GetString());
Console.WriteLine("a2: \n" + a2.GetString());
Console.WriteLine("\na1 " + (a1 == a2 ? "==" : "!=") + " a2");


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