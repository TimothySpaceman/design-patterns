namespace lab_3.Bridge;

public class Circle : Shape
{
    public int Radius { get; set; }
    
    public Circle(int x, int y, int radius) : base(x, y)
    {
        Radius = radius;
    }
    
    public override string ToString()
    {
        return $"circle with radius {Radius} at ({X}, {Y})";
    }
}