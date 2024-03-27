namespace lab_2.AbstractFactory;

public interface IAbstractFactory
{
    public IComputer CreateComputer(string os, string cpu, string gpu, int ram, int ssd);
    public ILaptop CreateLaptop(double diagonal, string os, string cpu, int ram, int ssd);

    public IMonitor CreateMonitor(double diagonal, string matrixType, double refreshRate, (int, int) resolution, bool hdr);

    public IPhone CreatePhone(double diagonal, int batteryCapacity, string os, int memorySize, int ram);
}