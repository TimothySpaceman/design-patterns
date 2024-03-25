namespace lab_1.AbstractFactory;

public class SamsungFactory : IAbstractFactory
{
    public IComputer CreateComputer(string os, string cpu, string gpu, int ram, int ssd)
    {
        return new SamsungComputer(os, cpu, gpu, ram, ssd);
    }

    public ILaptop CreateLaptop(double diagonal, string os, string cpu, int ram, int ssd)
    {
        return new SamsungLaptop(diagonal, os, cpu, ram, ssd);
    }

    public IMonitor CreateMonitor(double diagonal, string matrixType, double refreshRate, (int, int) resolution, bool hdr)
    {
        return new SamsungMonitor(diagonal, matrixType, refreshRate, resolution, hdr);
    }

    public IPhone CreatePhone(double diagonal, int batteryCapacity, string os, int memorySize, int ram)
    {
        return new SamsungPhone(diagonal, batteryCapacity, os, memorySize, ram);
    }
}