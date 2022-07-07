using Computers.Interfaces;

namespace Computers.Classes;

public class Ram : IRam
{
    public Ram(string brand, decimal memory)
    {
        RamBrand = brand;
        RamMemory = memory;
    }

    public string RamBrand { get; set; }
    public decimal RamMemory { get; set; }
}