namespace lab_3.Decorator;

public class Love : IEquipment
{
    public IEquipment? Wrappee { get; set; }
    
    public string Name { get; set; }
    
    public string Use(ICharacter actor, ICharacter target)
    {
        actor.Health += 10;
        target.Health += 10;
        return Wrappee?.Use(actor, target) + ", with love";
    }

    public Love(IEquipment? wrappee = null)
    {
        Wrappee = wrappee;
        Name = "Love";
    }
}