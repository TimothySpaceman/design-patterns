namespace lab_2.Builder;

public interface ICharacterBuilder
{
    public ICharacterBuilder SetSex(bool sex);
    public ICharacterBuilder SetName(string name);
    public ICharacterBuilder SetEyesColor(string eyesColor);
    public ICharacterBuilder SetHairColor(string hairColor);
    public ICharacterBuilder SetHeight(double height);
    public ICharacterBuilder SetBeardLevel(BeardLevels beardLevel);
    public ICharacterBuilder Reset();
    public Character GetCharacter();
}