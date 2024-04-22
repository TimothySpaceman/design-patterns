namespace lab_3.Bridge;

public class GraphicsEngine
{
    public Shape? Shape { get; set; }

    public GraphicsEngine(Shape? shape = null)
    {
        Shape = shape;
    }

    public string Render()
    {
        return $"Rendered {Shape}";
    }
}