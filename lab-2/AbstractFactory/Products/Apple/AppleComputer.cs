namespace lab_1.AbstractFactory;

public class AppleComputer : IComputer
{
    public string OS { get; set; }
    public string CPU { get; set; }
    public string GPU { get; set; }
    public int RAM { get; set; }
    public int SSD { get; set; }

    public AppleComputer(string os, string cpu, string gpu, int ram, int ssd)
    {
        OS = os;
        CPU = cpu;
        GPU = gpu;
        RAM = ram;
        SSD = ssd;
    }

    public override string ToString()
    {
        return $"Mac Pro, {RAM}GB RAM, {SSD}GB SSD, {CPU} CPU, {GPU} GPU, {OS}";
    }
}