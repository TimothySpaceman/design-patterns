namespace lab_1;

public class QRCodeGenerator
{
    //Of course, there could be any other implementation, it’s just an example
    public static string Prefix = "https://not-diia.app/documents/";
    
    public static string GenerateQR(string data)
    {
        return $"{Prefix}{data}";
    }
}