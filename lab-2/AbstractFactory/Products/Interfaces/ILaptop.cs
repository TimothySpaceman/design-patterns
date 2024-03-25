namespace lab_1.AbstractFactory;

public interface ILaptop
{
    public double Diagonal { get; set; }
    public string OS { get; set; }
    public string CPU { get; set; }
    public int RAM { get; set; }
    public int SSD { get; set; }
}