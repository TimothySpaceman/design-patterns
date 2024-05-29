namespace lab_5.Styles;

public class Style
{
    public static readonly Style Defaults = new Style(10, 5, 0, 0, ConsoleColor.Black, ConsoleColor.White);
    public int? Width;
    public int? Height;
    public int? Top;
    public int? Left;
    public ConsoleColor? BackgroundColor;
    public ConsoleColor? ForegroundColor;

    public Style(int? width = null, int? height = null, int? top = null, int? left = null, ConsoleColor? backgroundColor = null, ConsoleColor? foregroundColor = null)
    {
        Width = width;
        Height = height;
        Top = top;
        Left = left;
        BackgroundColor = backgroundColor;
        ForegroundColor = foregroundColor;
    }

    public Style(Style source)
    {
        Width = source.Width;
        Height = source.Height;
        Top = source.Top;
        Left = source.Left;
        BackgroundColor = source.BackgroundColor;
        ForegroundColor = source.ForegroundColor;
    }

    public void Merge(Style target)
    {
        Width = Width == null ? target.Width : Width;
        Height = Height == null ? target.Height : Height;
        Top = (target.Top ?? 0) + (Top ?? 0);
        Left = (target.Left ?? 0) + (Left ?? 0);
        BackgroundColor = BackgroundColor == null ? target.BackgroundColor : BackgroundColor;
        ForegroundColor = ForegroundColor == null ? target.ForegroundColor : ForegroundColor;
    }

    public bool Equals(Style target)
    {
        return Width == target.Width
            && Height == target.Height
            && Top == target.Top
            && Left == target.Left
            && BackgroundColor == target.BackgroundColor
            && ForegroundColor == target.ForegroundColor;
    }
}