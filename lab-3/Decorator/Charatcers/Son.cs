namespace lab_3.Decorator;

public class Son : ICharacter
{
    public string Name { get; set; }
    public int Health { get; set; }
    public IEquipment? Equipment { get; set; }
    
    public string Act(ICharacter target)
    {
        return $"{Name} {Equipment?.Use(this, target)}";
    }

    public ICharacter Have(IEquipment equipment)
    {
        equipment.Wrappee = Equipment;
        Equipment = equipment;
        return this;
    }

    public Son(string name, int health = 100, IEquipment? equipment = null)
    {
        Name = name;
        Health = health;
        Equipment = equipment;
    }
}