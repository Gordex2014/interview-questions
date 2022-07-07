using Computers.Enums;
using Computers.Interfaces;

namespace Computers.Classes;

public class License : ILicence
{
    public License(Os osName, string version)
    {
        OsName = osName;
        OsVersion = version;
    }

    public Os OsName { get; set; }
    public string OsVersion { get; set; }
}