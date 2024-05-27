namespace lab_4.Observer;

public class Event
{
    public LightElementNode Target;

    public Event(LightElementNode target)
    {
        Target = target;
    }
}