using System.Text.RegularExpressions;

namespace lab_2.Builder;

public class EnemyBuilder: ICharacterBuilder
{
    private Character _character = null!;

    public EnemyBuilder()
    {
        this.Reset();
    }

    public ICharacterBuilder SetSex(bool sex)
    {
        _character.Sex = sex;
        return this;
    }

    public ICharacterBuilder SetName(string name)
    {
        _character.Name = name;
        return this;
    }

    public ICharacterBuilder SetEyesColor(string eyesColor)
    {
        if(!IsHexColor(eyesColor))
            throw new ArgumentException("Eyes color value must be a hex color");
        
        _character.EyesColor = eyesColor;
        return this;
    }

    public ICharacterBuilder SetHairColor(string hairColor)
    {
        if(!IsHexColor(hairColor))
            throw new ArgumentException("Hair color value must be a hex color");
        
        _character.HairColor = hairColor;
        return this;
    }

    public ICharacterBuilder SetHeight(double height)
    {
        if(height < 0)
            throw new ArgumentException("Don't offend people shorter than you!");
        
        _character.Height = height;
        return this;
    }

    public ICharacterBuilder SetBeardLevel(BeardLevels beardLevel)
    {
        _character.BeardLevel = beardLevel;
        return this;
    }

    public ICharacterBuilder Reset()
    {
        _character = new Character
        {
            Desires = new List<string>() { "Break", "Destroy", "Hurt", "Hate", "Attack" }
        };
        return this;
    }

    private bool IsHexColor(string data)
    {
        return Regex.IsMatch(data, @"^#[0-9a-fA-F]{6}$");
    }

    public Character GetCharacter()
    {
        return _character;
    }
}