using Microsoft.VisualBasic;

namespace lab_1;

public class NotDiia
{
    public List<DocumentListItem> Documents { get; set; }

    public int CurrentIndex = 0;

    public IDisplayableDocument? CurrentDocument => Documents.Find(item => item.Position == CurrentIndex)?.Document; 

    private int NextIndex(int index) => (index + 1) % Documents.Count;
    private int PrevIndex(int index) => (index - 1 + Documents.Count) % Documents.Count;
    
    public NotDiia(List<DocumentListItem>? documents = null)
    {
        Documents = documents ?? new List<DocumentListItem>();
    }
    
    public void NextDocument()
    {
        if (Documents.Count == 0) return;
        CurrentDocument?.HideDocument();
        CurrentIndex = NextIndex(CurrentIndex);
    }
    
    public void PrevDocument()
    {
        if (Documents.Count == 0) return;
        CurrentDocument?.HideDocument();
        CurrentIndex = PrevIndex(CurrentIndex);
    }

    public void ShiftRight()
    {
        if (Documents.Count == 0) return;
        var currentItem = Documents.Find(item => item.Position == CurrentIndex);
        var nextItem = Documents.Find(item => item.Position == NextIndex(CurrentIndex));
        if (currentItem != null) currentItem.Position = NextIndex(CurrentIndex);
        if (nextItem != null) nextItem.Position = CurrentIndex;
        CurrentIndex = NextIndex(CurrentIndex);
    }
    
    public void ShiftLeft()
    {
        if (Documents.Count == 0) return;
        var currentItem = Documents.Find(item => item.Position == CurrentIndex);
        var prevItem = Documents.Find(item => item.Position == PrevIndex(CurrentIndex));
        if (currentItem == null || prevItem == null) return; 
        currentItem.Position = PrevIndex(CurrentIndex);
        prevItem.Position = CurrentIndex;
        CurrentIndex = PrevIndex(CurrentIndex);
    }

    public void AddDocument(IDisplayableDocument document)
    {
        Documents.Add(new DocumentListItem(document, Documents.Count));
    }
    
    public void RemoveDocument(IDisplayableDocument document)
    {
        var item = Documents.Find(item => item.Document == document);
        if (item == null) return;
        Documents.Remove(item);
        CurrentIndex = CurrentIndex % Documents.Count;
    }

    public void ShowDocument() => CurrentDocument?.ShowDocument();
    public void HideDocument() => CurrentDocument?.HideDocument();
    public void ShowInfo() => CurrentDocument?.ShowInfo();
    public void HideInfo() => CurrentDocument?.HideInfo();
    public void GenerateQR() => (CurrentDocument as IQRСodeGeneratable)?.GenerateQR();
    
}