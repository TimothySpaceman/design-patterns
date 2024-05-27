using lab_5.Nodes;

namespace lab_5.Events;

public class MouseOverEvent : Event
{
    public (int, int) Position;

    public MouseOverEvent((int, int) position, LightElementNode target) : base(target)
    {
        Position = position;
    }
}