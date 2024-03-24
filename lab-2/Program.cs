using lab_2.FactoryMethod;

Console.WriteLine("Factory method");
var managerCall = new ManagerCall();
Console.WriteLine(managerCall.GetBestSubscription("Tim",DateTime.Now, 100.00) + "\n");

Console.ReadLine();