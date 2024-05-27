namespace lab_4.Observer;

public class MouseOverEvent : Event
{
    public (int, int) Position;

    public MouseOverEvent((int, int) position, LightElementNode target) : base(target)
    {
        Position = position;
    }
}