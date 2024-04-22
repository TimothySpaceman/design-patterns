namespace lab_3.Decorator;

public interface ICharacter
{
    public string Name { get; set; }
    public int Health { get; set; }
    public IEquipment? Equipment { get; set; } // List<Equipment> is, probably, a better option, but there's lack of time so...
    public string Act(ICharacter target);
    public ICharacter Have(IEquipment equipment);
}