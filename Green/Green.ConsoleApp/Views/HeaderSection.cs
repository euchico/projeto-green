using Green.ConsoleApp.Utils;

namespace Green.ConsoleApp.Views;

public static class HeaderSection
{
    public static void Show()
    {
        ConsoleHelper.SafeClear();
        Console.WriteLine(GetHeaderArt());
        Console.WriteLine();
    }

    private static string GetHeaderArt()
    {
        return @"  ___ ___ ___ ___ _  _ 
 / __| _ \ __| __| \| |
| (_ |   / _|| _|| .` |
 \___|_|_\___|___|_|\_|";
    }
}
