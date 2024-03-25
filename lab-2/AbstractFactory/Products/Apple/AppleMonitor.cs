namespace lab_1.AbstractFactory;

public class AppleMonitor : IMonitor
{
    public double Diagonal { get; set; }
    public string MatrixType { get; set; }
    public double RefreshRate { get; set; }
    public (int, int) Resolution { get; set; }
    public bool HDR { get; set; }

    public AppleMonitor(double diagonal, string matrixType, double refreshRate, (int, int) resolution, bool hdr)
    {
        Diagonal = diagonal;
        MatrixType = matrixType;
        RefreshRate = refreshRate;
        Resolution = resolution;
        HDR = hdr;
    }

    public override string ToString()
    {
        return $"Pro Display {Diagonal}\', {MatrixType}, {RefreshRate}Hz, {Resolution.Item1}x{Resolution.Item1}" + (HDR ? ", HDR" : "");
    }
}