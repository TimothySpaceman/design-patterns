namespace lab_1;

public class DocumentListItem
{
    public IDisplayableDocument Document { get; set; }
    public int Position { get; set; }

    public DocumentListItem(IDisplayableDocument document, int position)
    {
        Document = document;
        Position = position;
    }
}