namespace lab_4.Mediator;

public class Runway : AirTrafficUnit
{
    public readonly Guid Id = Guid.NewGuid();
    
    public Runway(CommandCentre commandCentre) : base(commandCentre)
    {
    }

    public bool IsFree()
    {
        return CommandCentre.Notify(this, "is-free");
    }
}