namespace lab_3.Decorator;

public class Softness : IEquipment
{
    public IEquipment? Wrappee { get; set; }
    
    public string Name { get; set; }
    
    public string Use(ICharacter actor, ICharacter target)
    {
        actor.Health += 10;
        target.Health += 10;
        return Wrappee?.Use(actor, target) + ", with softness";
    }

    public Softness(IEquipment? wrappee = null)
    {
        Wrappee = wrappee;
        Name = "Softness";
    }
}