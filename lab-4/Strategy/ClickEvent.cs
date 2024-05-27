namespace lab_4.Strategy;

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