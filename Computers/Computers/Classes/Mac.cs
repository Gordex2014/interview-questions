using Computers.Enums;
using Computers.Interfaces;

namespace Computers.Classes;

public class Mac : IMac
{
    public Mac()
    {
        ProcessorBrand = "Apple M1";
        ProcessorFrequency = 3.2;
        RamBrand = "Apple";
        RamMemory = 16;
        OsName = Os.Mac;
        OsVersion = "Mac Os Monterrey";
    }

    public string ProcessorBrand { get; set; }
    public double ProcessorFrequency { get; set; }
    public string RamBrand { get; set; }
    public decimal RamMemory { get; set; }
    public Os OsName { get; set; }
    public string OsVersion { get; set; }
}