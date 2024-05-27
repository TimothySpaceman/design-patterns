namespace lab_4.Memento;

public class Editor
{
    public Message Message = new Message();

    public Stack<Snapshot> UndoHistory = new Stack<Snapshot>();
    
    public Stack<Snapshot> RedoHistory = new Stack<Snapshot>();

    public void Input(string value)
    {
        UndoHistory.Push(Message.GetSnapshot());
        RedoHistory = new Stack<Snapshot>();
        Message.Text += value;
    }

    public void Backspace(int count)
    {
        UndoHistory.Push(Message.GetSnapshot());
        RedoHistory = new Stack<Snapshot>();
        Message.Text = Message.Text.Substring(0, Math.Max(Message.Text.Length - count, 0));
    }

    public void Undo()
    {
        var snapshot = UndoHistory.Pop();
        RedoHistory.Push(Message.GetSnapshot());
        snapshot.Restore();
    }
    
    public void Redo()
    {
        var snapshot = RedoHistory.Pop();
        UndoHistory.Push(Message.GetSnapshot());
        snapshot.Restore();
    }
    
}