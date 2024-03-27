namespace lab_2.AbstractFactory;

public interface IComputer
{
    public string OS { get; set; }
    public string CPU { get; set; }
    public string GPU { get; set; }
    public int RAM { get; set; }
    public int SSD { get; set; }
}