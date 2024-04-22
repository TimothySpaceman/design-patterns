namespace lab_3.Bridge;

public class VectorGraphicsEngine: GraphicsEngine
{
    public VectorGraphicsEngine(Shape? shape = null) : base(shape)
    {
    }

    public string Render()
    {
        return $"{base.Render()} with vectors";
    }
}