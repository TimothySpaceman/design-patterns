namespace lab_1;

public class DrivingLicense: IDisplayableDocument, IPhotographable, IQRСodeGeneratable
{
    public PersonalInfo PersonalInfo { get; private set; }
    public string Photo { get; private set; }
    public List<DrivingCategoryItem> Categories { get; private set; }
    public string Series { get; private set; }   
    public int Number { get; private set; }
    public string SeriesWithNumber => $"{Series}{Number}";

    public DrivingLicense(PersonalInfo personalInfo, string photo, string series, int number)
    {
        PersonalInfo = personalInfo;
        Photo = photo;
        Series = series;
        Number = number;
        Categories = new List<DrivingCategoryItem>();
    }

    public void AddCategory(VehicleCategory category, DateTime dateOfExpiry)
    {
        Categories.RemoveAll(item => item.VehicleCategory == category);
        Categories.Add(new DrivingCategoryItem(category, dateOfExpiry));
    }

    public void RemoveCategory(VehicleCategory category)
    {
        Categories.RemoveAll(item => item.VehicleCategory == category);
    }

    public void ShowDocument()
    {
        Console.WriteLine($"Show Driving License {SeriesWithNumber}");
        Console.WriteLine($"Owner: {PersonalInfo.FirstName} {PersonalInfo.LastName}");
        Console.Write("Cathegories: ");
        foreach (var item in Categories)
        {
            Console.Write($"{Enum.GetName(item.VehicleCategory)} ");
        }
        Console.WriteLine();
    }

    public void HideDocument()
    {
        Console.WriteLine($"Hide Driving License {SeriesWithNumber}");
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Show info for Driving License {SeriesWithNumber}");
    }
    
    public void HideInfo()
    {
        Console.WriteLine($"Hide info for Driving License {SeriesWithNumber}");
    }

    public void GenerateQR()
    {
        Console.WriteLine(QRCodeGenerator.GenerateQR(SeriesWithNumber));
    }
}