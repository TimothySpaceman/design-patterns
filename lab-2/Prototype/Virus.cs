using System.Text;

namespace lab_2.Prototype;

public class Virus: IPrototype
{
    public double Weight { get; set; }
    public int Gen { get; set; } //Let's assume that it's an age
    public string Name { get; set; }
    public string Type { get; set; }
    public List<IPrototype> Children { get; set; }

    public Virus(double weight, int gen, string name, string type, List<IPrototype>? children = null)
    {
        Weight = weight;
        Gen = gen;
        Name = name;
        Type = type;
        Children = children ?? new List<IPrototype>();
    }

    public Virus(Virus prototype)
    {
        Weight = prototype.Weight;
        Gen = prototype.Gen;
        Name = prototype.Name;
        Type = prototype.Type;
        Children = prototype.Children.Select(child => child.Clone()).ToList();
    }

    public IPrototype Clone()
    {
        return new Virus(this);
    }

    public string GetString(int childLevel = 1)
    {
        var sb = new StringBuilder();
        sb.Append($"{Name} - {Type} {Gen}th");
        
        foreach (var child in Children)
        {
            sb.Append("\n");
            sb.Append(new string(' ', childLevel * 4));
            sb.Append(((Virus)child).GetString(childLevel + 1));
        }

        return sb.ToString();
    }
}