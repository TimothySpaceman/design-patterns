namespace lab_1;

public class MilitaryID: IDisplayableDocument, IPhotographable, IQRСodeGeneratable
{
    public PersonalInfo PersonalInfo { get; private set; }
    public string Photo { get; private set; }
    public string Series { get; private set; }   
    public int Number { get; private set; }
    public string SeriesWithNumber => $"{Series}{Number}";
    
    public EnrollAbility EnrollAbility { get; set; }

    public MilitaryID(PersonalInfo personalInfo, string photo, string series, int number, EnrollAbility enrollAbility)
    {
        PersonalInfo = personalInfo;
        Photo = photo;
        Series = series;
        Number = number;
        EnrollAbility = enrollAbility;
    }

    public void ShowDocument()
    {
        Console.WriteLine($"Show Military ID {SeriesWithNumber}");
        Console.WriteLine($"Owner: {PersonalInfo.FirstName} {PersonalInfo.LastName}");
        Console.WriteLine($"Enroll ability: {Enum.GetName(EnrollAbility)}");
    }

    public void HideDocument()
    {
        Console.WriteLine($"Hide Military ID {SeriesWithNumber}");
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Show info for Military ID {SeriesWithNumber}");
    }
    
    public void HideInfo()
    {
        Console.WriteLine($"Hide info for Military ID {SeriesWithNumber}");
    }

    public void GenerateQR()
    {
        Console.WriteLine(QRCodeGenerator.GenerateQR(SeriesWithNumber));
    }
}