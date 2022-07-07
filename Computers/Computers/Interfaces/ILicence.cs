using Computers.Enums;

namespace Computers.Interfaces;

public interface ILicence
{
    public Os OsName { get; set; }
    public string OsVersion { get; set; }
}