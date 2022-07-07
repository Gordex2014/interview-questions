using Computers.Interfaces;

namespace Computers.Utils;

public static class Printer
{
    public static void ComputerProperties(IComputer computer)
    {
        Specs();
        Console.WriteLine("Computer properties");
        Console.WriteLine($"Processor brand: {computer.ProcessorBrand}");
        Console.WriteLine($"Processor frequency: {computer.ProcessorFrequency}");
        Console.WriteLine($"Ram brand: {computer.RamBrand}");
        Console.WriteLine($"Ram memory: {computer.RamMemory}");
    }
    
    public static void MacProperties(IMac? mac)
    {
        Specs();
        Console.WriteLine("Mac properties");
        Console.WriteLine($"Processor brand: {mac.ProcessorBrand}");
        Console.WriteLine($"Processor frequency: {mac.ProcessorFrequency}");
        Console.WriteLine($"Ram brand: {mac.RamBrand}");
        Console.WriteLine($"Ram memory: {mac.RamMemory}");
        Console.WriteLine($"Os name: {mac.OsName}");
        Console.WriteLine($"Os version: {mac.OsVersion}");
    }
    
    public static void WindowsProperties(IWindows windows)
    {
        Specs();
        Console.WriteLine("Windows properties");
        Console.WriteLine($"Processor brand: {windows.ProcessorBrand}");
        Console.WriteLine($"Processor frequency: {windows.ProcessorFrequency}");
        Console.WriteLine($"Ram brand: {windows.RamBrand}");
        Console.WriteLine($"Ram memory: {windows.RamMemory}");
        Console.WriteLine($"Os name: {windows.OsName}");
        Console.WriteLine($"Os version: {windows.OsVersion}");
    }

    public static void Specs()
    {
        Console.WriteLine(@"
    .__________________________.
    | .___________________. |==|
    | | ................. | |  |
    | | ::::::::::::::::: | |  |
    | | ::::::::::::::::: | |  |
    | | ::::::::::::::::: | |  |
    | | ::::::::::::::::: | |  |
    | | ::::::::::::::::: | |  |
    | | ::::::::::::::::: | | ,|
    | !___________________! |(c|
    !_______________________!__!
   /                            \
  /  [][][][][][][][][][][][][]  \
 /  [][][][][][][][][][][][][][]  \
(  [][][][][____________][][][][]  )
 \ ------------------------------ /
  \______________________________/
        ");
    }
}