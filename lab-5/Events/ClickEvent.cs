using lab_5.Nodes;

namespace lab_5.Events;

public class ClickEvent : Event
{
    public (int, int) Position;
    public int Button;

    public ClickEvent((int, int) position, int button, LightElementNode target) : base(target)
    {
        Position = position;
        Button = button;
    }
}