using Computers.Classes;
using Computers.Interfaces;
using Computers.Utils;

var answer = Menu.MainMenu();
IComputer computer = null;

switch (answer)
{
    case "Windows":
        computer = new Windows();
        break;
    case "Mac":
        computer = new Mac();
        break;
    case "Linux":
        computer = new Linux();
        break;
    case "Custom":
        Computer customComputer;
        var processorBrand = Menu.ProcessorBrand();
        var ramBrand = Menu.RamBrands();
        var videoCard = Menu.VideoCard();
        var licenceType = Menu.LicenceTypes();
        if (videoCard)
        {
            customComputer = new Computer(processorBrand, ramBrand, videoCard, licenceType);
            customComputer.PrintProperties();
        }
        else
        {
            customComputer = new Computer(processorBrand, ramBrand, licenceType);
            customComputer.PrintProperties();
        }
        break;
}

if (computer is IMac mac)
{
    Printer.MacProperties(mac);
}
else if (computer is IWindows windows)
{
    Printer.WindowsProperties(windows);
}
else
{
    Printer.ComputerProperties(computer);
}
