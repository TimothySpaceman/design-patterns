namespace lab_2.AbstractFactory;

public class AppleLaptop : ILaptop
{
    public double Diagonal { get; set; }
    public string OS { get; set; }
    public string CPU { get; set; }
    public int RAM { get; set; }
    public int SSD { get; set; }

    public AppleLaptop(double diagonal, string os, string cpu, int ram, int ssd)
    {
        Diagonal = diagonal;
        OS = os;
        CPU = cpu;
        RAM = ram;
        SSD = ssd;
    }
    
    public override string ToString()
    {
        return $"MacBook {Diagonal}\', {RAM}GB RAM, {SSD}GB SSD, {CPU} CPU, {OS}";
    }
}