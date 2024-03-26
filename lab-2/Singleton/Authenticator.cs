namespace lab_1.Singleton;

public sealed class Authenticator //"sealed" prevents the inheritance 
{
    //Lazy<T> provides thread-safe lazy initialization
    private static Lazy<Authenticator> _lazy = new(() => new Authenticator());
    
    private Authenticator()
    {
        Console.WriteLine("Authenticator initialized");
    }

    public static Authenticator GetInstance()
    {
        return _lazy.Value;
    }
}