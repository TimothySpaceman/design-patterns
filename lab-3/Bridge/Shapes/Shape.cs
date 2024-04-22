namespace lab_3.Bridge;

public class Shape
{
    public int X { get; set; }
    public int Y { get; set; }

    public Shape(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"shape at ({X}, {Y})";
    }
}