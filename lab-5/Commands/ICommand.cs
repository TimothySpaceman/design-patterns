namespace lab_5.Commands;

public interface ICommand
{
    public void Execute();
    public void Undo();
}