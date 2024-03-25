namespace lab_1.AbstractFactory;

public class AppleFactory : IAbstractFactory
{
    public IComputer CreateComputer(string os, string cpu, string gpu, int ram, int ssd)
    {
        return new AppleComputer(os, cpu, gpu, ram, ssd);
    }

    public ILaptop CreateLaptop(double diagonal, string os, string cpu, int ram, int ssd)
    {
        return new AppleLaptop(diagonal, os, cpu, ram, ssd);
    }

    public IMonitor CreateMonitor(double diagonal, string matrixType, double refreshRate, (int, int) resolution, bool hdr)
    {
        return new AppleMonitor(diagonal, matrixType, refreshRate, resolution, hdr);
    }

    public IPhone CreatePhone(double diagonal, int batteryCapacity, string os, int memorySize, int ram)
    {
        return new ApplePhone(diagonal, batteryCapacity, os, memorySize, ram);
    }
}