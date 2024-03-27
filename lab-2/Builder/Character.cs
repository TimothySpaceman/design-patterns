using System.Text;

namespace lab_2.Builder;

public class Character
{
    public bool Sex { get; set; }
    public string Name { get; set; }
    public string EyesColor { get; set; }
    public string HairColor { get; set; }
    public double Height { get; set; }
    public BeardLevels BeardLevel { get; set; }
    public List<string> Desires { get; set; }
    //Alright, that's enough for $0.00 budget and missed deadline

    public Character()
    {
        Sex = true;
        Name = "";
        EyesColor = "#05C3DD";
        HairColor = "#3E1C00";
        Height = 1.75;
        BeardLevel = BeardLevels.None;
        Desires = new List<string>();
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        return sb
            .Append(Sex ? "He" : "She")
            .Append(" is the one who loves to ")
            .Append(string.Join(", ", Desires))
            .Append($"\nHair color: {HairColor}")
            .Append($"\nEyes color: {EyesColor}")
            .Append($"\nBeard: {BeardLevels.GetName(BeardLevel)}")
            .ToString();
    }
}