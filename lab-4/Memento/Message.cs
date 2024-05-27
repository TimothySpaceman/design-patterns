namespace lab_4.Memento;

public class Message
{
    public string Text;

    public Snapshot GetSnapshot()
    {
        return new Snapshot(this, Text);
    }
}