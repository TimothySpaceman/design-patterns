namespace lab_3.Decorator;

public class Hug : IEquipment
{
    public IEquipment? Wrappee { get; set; }
    
    public string Name { get; set; }
    
    public string Use(ICharacter actor, ICharacter target)
    {
        actor.Health += 20;
        target.Health += 20;
        return $"gives {target.Name} a hug";
    }

    public Hug()
    {
        Wrappee = null;
        Name = "Hug";
    }
}