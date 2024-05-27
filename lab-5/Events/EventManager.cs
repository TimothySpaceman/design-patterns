namespace lab_5.Events;
public class EventManager
{
    public List<(string, List<Action<Event>>)> Listeners = new List<(string, List<Action<Event>>)>();

    public void AddListener(string eventName, Action<Event> listener)
    {
        var listenersListIndex = Listeners.FindIndex(nameAndList => nameAndList.Item1 == eventName);
        if (listenersListIndex < 0)
        {
            Listeners.Add((eventName, new List<Action<Event>>{listener}));
            return;
        }
        Listeners[listenersListIndex].Item2.Add(listener);
    }
    
    public void RemoveListener(string eventName, Action<Event> listener)
    {
        var listenersListIndex = Listeners.FindIndex(nameAndList => nameAndList.Item1 == eventName);
        if (listenersListIndex < 0)
        {
            return;
        }
        Listeners[listenersListIndex].Item2.Remove(listener);
    }

    public void NotifyListeners(string eventName, Event eventInstance)
    {
        var listenersListIndex = Listeners.FindIndex(nameAndList => nameAndList.Item1 == eventName);
        if (listenersListIndex < 0)
        {
            return;
        }
        Listeners[listenersListIndex].Item2.ForEach(listener=>listener(eventInstance));
    }
}