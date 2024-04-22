namespace lab_3.Decorator;

public class Kindness : IEquipment
{
    public IEquipment? Wrappee { get; set; }
    
    public string Name { get; set; }
    
    public string Use(ICharacter actor, ICharacter target)
    {
        actor.Health += 10;
        target.Health += 10;
        return Wrappee?.Use(actor, target) + ", with kindness";
    }

    public Kindness(IEquipment? wrappee = null)
    {
        Wrappee = wrappee;
        Name = "Kindness";
    }
}