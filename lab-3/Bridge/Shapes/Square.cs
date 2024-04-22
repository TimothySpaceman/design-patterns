namespace lab_3.Bridge;

public class Square : Shape
{
    public int X2 { get; set; }
    public int Y2 { get; set; }
    
    public Square(int x, int y, int x2, int y2) : base(x, y)
    {
        X2 = x2;
        Y2 = y2;
    }
    
    public override string ToString()
    {
        return $"square with corners at ({X}, {Y}) and ({X2}, {Y2})";
    }
}