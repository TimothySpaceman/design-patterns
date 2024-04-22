namespace lab_3.Bridge;

public class Triangle : Shape
{
    public int X2 { get; set; }
    public int Y2 { get; set; }
    public int X3 { get; set; }
    public int Y3 { get; set; }
    
    public Triangle(int x, int y, int x2, int y2, int x3, int y3) : base(x, y)
    {
        X2 = x2;
        Y2 = y2;
        X3 = x3;
        Y3 = y3;
    }
    
    public override string ToString()
    {
        return $"triangle with A({X}, {Y}), B({X2}, {Y2}) and C({X3}, {Y3})";
    }
}