namespace lab_1;

public class Passport: IDisplayableDocument, IPhotographable, IQRСodeGeneratable
{
    public PersonalInfo PersonalInfo { get; private set; }
    public string Photo { get; private set; }
    public DateTime DateOfExpiry { get; private set; }
    public string RNTRC { get; private set; }
    public string Series { get; private set; }   
    public int Number { get; private set; }
    public string SeriesWithNumber => $"{Series}{Number}";

    public Passport(PersonalInfo personalInfo, string photo, DateTime dateOfExpiry, string rntrc, string series, int number)
    {
        PersonalInfo = personalInfo;
        Photo = photo;
        DateOfExpiry = dateOfExpiry;
        RNTRC = rntrc;
        Series = series;
        Number = number;
    }
    
    public void ShowDocument()
    {
        Console.WriteLine($"Show Passport {SeriesWithNumber}");
        Console.WriteLine($"Owner: {PersonalInfo.FirstName} {PersonalInfo.LastName}");
    }

    public void HideDocument()
    {
        Console.WriteLine($"Hide Passport {SeriesWithNumber}");
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Show info for Passport {SeriesWithNumber}");
    }
    
    public void HideInfo()
    {
        Console.WriteLine($"Hide info for Passport {SeriesWithNumber}");
    }

    public void CopyRNTRC()
    {
        Console.WriteLine($"RNTRC: {RNTRC}");
    }

    public void GenerateQR()
    {
        Console.WriteLine(QRCodeGenerator.GenerateQR(SeriesWithNumber));
    }
}