using Computers.Enums;
using Computers.Interfaces;

namespace Computers.Classes;

public class Windows : IWindows
{
    public Windows()
    {
        ProcessorBrand = "Intel Core i7 11° Gen";
        ProcessorFrequency = 3.7;
        RamBrand = "ASUS";
        RamMemory = 16;
        OsName = Os.Windows;
        OsVersion = "Windows 11";
    }

    public string ProcessorBrand { get; set; }
    public double ProcessorFrequency { get; set; }
    public string RamBrand { get; set; }
    public decimal RamMemory { get; set; }
    public Os OsName { get; set; }
    public string OsVersion { get; set; }
}