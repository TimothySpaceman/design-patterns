namespace lab_3.Decorator;

public interface IEquipment // Or characteristic
{
    public IEquipment? Wrappee { get; set; }
    public string Name { get; set; }
    public string Use(ICharacter actor, ICharacter target);
}