namespace lab_1;

public interface IDocument
{
    public PersonalInfo PersonalInfo { get; }
    public string Series { get; }
    public int Number { get; }
    public string SeriesWithNumber { get; }
}