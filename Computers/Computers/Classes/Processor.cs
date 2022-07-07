using Computers.Interfaces;

namespace Computers.Classes;

public class Processor : IProcessor
{
    public Processor(string brand, double frequency)
    {
        ProcessorBrand = brand;
        ProcessorFrequency = frequency;
    }

    public string ProcessorBrand { get; set; }
    public double ProcessorFrequency { get; set; }
}