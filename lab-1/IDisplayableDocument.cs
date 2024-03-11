namespace lab_1;

public interface IDisplayableDocument: IDocument
{
    public void ShowDocument();

    public void HideDocument();
    
    public void ShowInfo();
    
    public void HideInfo();
}