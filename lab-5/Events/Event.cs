using lab_5.Nodes;

namespace lab_5.Events;

public class Event
{
    public LightElementNode Target;

    public Event(LightElementNode target)
    {
        Target = target;
    }
}