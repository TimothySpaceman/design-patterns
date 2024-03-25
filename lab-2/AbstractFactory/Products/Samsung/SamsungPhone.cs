namespace lab_1.AbstractFactory;

public class SamsungPhone : IPhone
{
    public double Diagonal { get; set; }
    public int BatteryCapacity { get; set; }
    public string OS { get; set; }
    public int MemorySize { get; set; }
    public int RAM { get; set; }

    public SamsungPhone(double diagonal, int batteryCapacity, string os, int memorySize, int ram)
    {
        Diagonal = diagonal;
        BatteryCapacity = batteryCapacity;
        OS = os;
        MemorySize = memorySize;
        RAM = ram;
    }

    public override string ToString()
    {
        return $"Samsung Phone {Diagonal}\', {RAM}GB RAM, {MemorySize}GB Memory, {OS}";
    }
}