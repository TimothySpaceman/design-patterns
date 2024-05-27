namespace lab_4.Mediator;

public class AirTrafficUnit
{
    public CommandCentre CommandCentre;

    public AirTrafficUnit(CommandCentre commandCentre)
    {
        CommandCentre = commandCentre;
        CommandCentre.Notify(this, "assign");
    }
}