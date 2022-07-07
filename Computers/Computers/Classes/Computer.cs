using Computers.Enums;
using Computers.Interfaces;
using Computers.Utils;

namespace Computers.Classes;

public class Computer : IComputer
{
    public License License { get; }
    public string ProcessorBrand { get; set; }
    public string RamBrand { get; set; }
    public decimal RamMemory { get; set; }
    public double ProcessorFrequency { get; set; }
    public bool DedicatedGraphics { get; set; }

    /// <summary>
    /// Creates a PC with custom components and a dedicated graphic card, only applicable to Linux and Windows OS.
    /// </summary>
    /// <param name="processorBrand">Processor brand</param>
    /// <param name="ramBrand">Ram brand</param>
    /// <param name="dedicatedGraphics">Flag that indicates this PC has a dedicated graphic card</param>
    /// <param name="os">The OS</param>
    public Computer(string processorBrand, string ramBrand, bool dedicatedGraphics, Os? os)
    {
        RamMemory = 16;
        ProcessorFrequency = 3.7;
        ProcessorBrand = processorBrand;
        RamBrand = ramBrand;
        DedicatedGraphics = dedicatedGraphics;
        if (os != null) License = new License(Os.Windows, "Windows 11");
    }
    
    /// <summary>
    /// Creates a PC with custom components.
    /// </summary>
    /// <param name="processorBrand">Processor brand</param>
    /// <param name="ramBrand">Ram brand</param>
    /// <param name="os">The OS</param>
    public Computer(string processorBrand, string ramBrand, Os? os)
    {
        RamMemory = 16;
        ProcessorFrequency = 3.7;
        ProcessorBrand = processorBrand;
        RamBrand = ramBrand;
        DedicatedGraphics = false;
        if (os == Os.Mac)
        {
            License = new License(Os.Mac, "Mac Os Monterrey");
        }
        if (os == Os.Windows)
        {
            License = new License(Os.Windows, "Windows 11");
        }
    }

    public void PrintProperties()
    {
        Printer.Specs();
        Console.WriteLine("Computer properties");
        Console.WriteLine($"Processor brand: {ProcessorBrand}");
        Console.WriteLine($"Processor frequency: {ProcessorBrand}");
        Console.WriteLine($"Ram brand: {RamBrand}");
        Console.WriteLine($"Ram memory: {RamMemory}");
        Console.WriteLine($"Dedicated Graphics: {DedicatedGraphics}");
        Console.WriteLine($"Os name: {License.OsName}");
        Console.WriteLine($"Os version: {License.OsVersion}");

        Environment.Exit(0);
    }
}