namespace lab_1.AbstractFactory;

public interface IPhone //Better than Android?
{
    public double Diagonal { get; set; }
    public int BatteryCapacity { get; set; }
    public string OS { get; set; }
    public int MemorySize { get; set; }
    public int RAM { get; set; }
}