namespace lab_4.Memento;

public class Snapshot
{
    public string Text;
    public Message Message;

    public Snapshot(Message message, string text)
    {
        Message = message;
        Text = text;
    }

    public void Restore()
    {
        Message.Text = Text;
    }
}