namespace lab_2.Builder;

public class CharacterDirector
{
    private ICharacterBuilder? _builder = null;

    public CharacterDirector SetBuilder(ICharacterBuilder builder)
    {
        _builder = builder;
        return this;
    }

    public Character GetNiceGuy(string name)
    {
        SetBuilder(new HeroBuilder());
        var r = new Random();
        
        return _builder!
            .SetName(name)
            .SetSex(true)
            .SetHeight(1.70 + r.NextDouble() * 0.2)
            .SetEyesColor("#04C4DE")
            .SetHairColor("#3E1C00")
            .SetBeardLevel(BeardLevels.Gandalf) //Wise Dude 😎
            .GetCharacter();
    }
    
    public Character GetBadGuy(string name)
    {
        SetBuilder(new EnemyBuilder());
        var r = new Random();
        
        return _builder!
            .SetName(name)
            .SetSex(true)
            .SetHeight(1.70 + r.NextDouble() * 0.2)
            .SetEyesColor("#E18A21")
            .SetHairColor("#33302B")
            .SetBeardLevel(BeardLevels.Biker) //Sorry Bikers
            .GetCharacter();
    }
}