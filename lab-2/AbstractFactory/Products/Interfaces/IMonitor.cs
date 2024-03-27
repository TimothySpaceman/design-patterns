namespace lab_2.AbstractFactory;

public interface IMonitor
{
    public double Diagonal { get; set; }
    public string MatrixType { get; set; } //Nice place to use enum but... Anyway
    public double RefreshRate { get; set; }
    public (int, int) Resolution { get; set; }
    public bool HDR { get; set; }
}