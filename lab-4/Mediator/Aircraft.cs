namespace lab_4.Mediator;

public class Aircraft : AirTrafficUnit
{
    public readonly Guid Id = Guid.NewGuid();
    public string Name;
    public bool isLanded = false;
    
    public Aircraft(string name, CommandCentre commandCentre) : base(commandCentre)
    {
        Name = name;
    }
    
    public void Land()
    {
        Console.WriteLine($"Aircraft {Name} ({Id}) is trying to land");
        Console.WriteLine("Asking for free runway...");
        isLanded = CommandCentre.Notify(this, "land");
    }
    
    public void TakeOff()
    {
        Console.WriteLine($"Aircraft {Name} ({Id}) is taking off");
        isLanded = !CommandCentre.Notify(this, "take-off");
    }
}