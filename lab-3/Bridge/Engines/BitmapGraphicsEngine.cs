namespace lab_3.Bridge;

public class BitmapGraphicsEngine: GraphicsEngine
{
    public BitmapGraphicsEngine(Shape? shape = null) : base(shape)
    {
    }

    public string Render()
    {
        return $"{base.Render()} with pixels";
    }
}