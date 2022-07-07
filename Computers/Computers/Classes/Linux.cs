using Computers.Interfaces;

namespace Computers.Classes;

public class Linux : ILinux
{
    public Linux()
    {
        ProcessorBrand = "Intel Core i7 11° Gen";
        ProcessorFrequency = 3.7;
        RamBrand = "ASUS";
        RamMemory = 16;
    }

    public string ProcessorBrand { get; set; }
    public double ProcessorFrequency { get; set; }
    public string RamBrand { get; set; }
    public decimal RamMemory { get; set; }
}