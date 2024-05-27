namespace lab_4.Mediator;

public class CommandCentre
{
    public List<Runway> Runways = new List<Runway>();
    public List<Aircraft> Aircrafts = new List<Aircraft>();
    public List<(Guid, Guid?)> RunwaysAircrafts = new List<(Guid, Guid?)>();

    public CommandCentre()
    {
    }

    public bool Notify(AirTrafficUnit sender, string eventName)
    {
        if (sender is Aircraft)
        {
            var aircraft = (Aircraft)sender;
            switch (eventName)
            {
                case "assign":
                    Aircrafts.Add(aircraft);
                    break;
                case "land":
                    if (aircraft.isLanded)
                    {
                        Console.WriteLine($"Aircraft is already landed");
                        return true;
                    }

                    var freeRunwayIdx = RunwaysAircrafts.FindIndex(ids => ids.Item2 is null);
                    if (freeRunwayIdx < 0)
                    {
                        Console.WriteLine("Landing failed: No runaways available");
                        return false;
                    }

                    var freeRunwayId = RunwaysAircrafts[freeRunwayIdx].Item1;
                    RunwaysAircrafts[freeRunwayIdx] = (freeRunwayId, aircraft.Id);
                    Console.WriteLine(
                        $"Aircraft {aircraft.Name} ({aircraft.Id}) landed on Runway {freeRunwayId}");
                    return true;
                case "take-off":
                    if (!aircraft.isLanded)
                    {
                        Console.WriteLine($"Aircraft  has already taken off");
                        return true;
                    }
                    
                    var runwayIdx = RunwaysAircrafts.FindIndex(ids => ids.Item2 == aircraft.Id);
                    if (runwayIdx < 0)
                    {
                        Console.WriteLine("Cannot find related runway");
                        return false;
                    }
                    
                    var runwayId = RunwaysAircrafts[runwayIdx].Item1;
                    RunwaysAircrafts[runwayIdx] = (runwayId, null);
                    
                    Console.WriteLine($"Aircraft {aircraft.Name} ({aircraft.Id}) has taken off, runway {runwayId} is now free");
                    return true;
                default:
                    return false;
            }
        }

        if (sender is Runway)
        {
            var runway = (Runway)sender;
            switch (eventName)
            {
                case "assign":
                    Runways.Add(runway);
                    RunwaysAircrafts.Add((runway.Id, null));
                    break;
                case "is-free":
                    return RunwaysAircrafts.Find(ids => ids.Item1 == runway.Id).Item2 is null;
                default:
                    return false;
            }
        }

        return false;
    }
}