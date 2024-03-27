using System.Diagnostics;
using System.Text;

namespace lab_2.Prototype;

public class PrettyVirus: Virus
{
    public double Weight { get; set; }
    public int Gen { get; set; } //Let's assume that it's an age
    public string Name { get; set; }
    public string Type { get; set; }
    
    public string Icon { get; set; } //May be the photo
    
    public List<IPrototype> Children { get; set; }

    public PrettyVirus(double weight, int gen, string name, string type, List<IPrototype> children, string icon): base(weight, gen, name, type, children)
    {
        Icon = icon;
    }

    public PrettyVirus(PrettyVirus prototype): base(prototype)
    {
        Icon = prototype.Icon;
    }

    public IPrototype Clone()
    {
        return new Virus(this);
    }

    public string GetString(int childLevel = 0)
    {
        var sb = new StringBuilder();
        sb.Append($"{Icon} {Name} - {Type} {Gen}th");
        
        foreach (var child in Children)
        {
            sb.Append(new string(' ', childLevel * 4));
            sb.Append(((PrettyVirus)child).GetString(childLevel + 1));
            sb.Append("\n");
        }

        return sb.Append("\n").ToString();
    }
}