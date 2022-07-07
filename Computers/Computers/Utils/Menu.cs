using Computers.Enums;
using Computers.Utils.Enums;
using InquirerCS;

namespace Computers.Utils;

public static class Menu
{
    public static string MainMenu()
    {
        return Question.List("Choose your PC type:", Enum.GetNames(typeof(MainMenuOptions))).Prompt();
    }

    public static string ProcessorBrand()
    {
        return Question.List("Choose your processor brand:", Enum.GetNames(typeof(ProcessorBrands))).Prompt();
    }

    public static string RamBrands()
    {
        return Question.List("Choose your Ram brand:", Enum.GetNames(typeof(RamBrands))).Prompt();
    }

    public static Os? LicenceTypes()
    {
        var os = Question.List("Choose your licence type:", Enum.GetNames(typeof(LicenceTypes))).Prompt();
        if (os == "Linux")
        {
            return null;
        }
        return os == "Mac" ? Os.Mac : Os.Windows;
    }

    public static bool VideoCard()
    {
        var videoAnswer = Question.List("Do you want a video card processor?:", Enum.GetNames(typeof(VideoCard))).Prompt();
        return videoAnswer == "Yes";
    }
}