using Green.Utility;

namespace Green.View;

internal class Screen
{
    protected TextManager TextContent { get; set; } = new TextManager();

    protected string ScreenTitle { get; }

    protected bool StatusLoop { get; set; }

    protected Screen(string screenTitle)
    {
        ScreenTitle = screenTitle!;
        StatusLoop = true;

        SetConsole();
        ShowHeader(ScreenTitle);
    }

    private static void SetConsole()
    {
        Console.Title = "Green";
    }

    private static void ShowLogo()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(@"
█▀▀ █▀█ █▀▀ █▀▀ █▄░█
█▄█ █▀▄ ██▄ ██▄ █░▀█");
        Console.WriteLine();
        Console.ResetColor();
    }

    private static void ShowScreenTitle(string screenTitle)
    {
        Console.WriteLine($"■ Tela: {screenTitle.ToUpper()} \n");
    }

    protected static void ShowHeader(string screenTitle)
    {
        Console.Clear();

        ShowLogo();
        ShowScreenTitle(screenTitle);
    }

    protected internal virtual bool ScreenLoop() { return true; }
    protected internal virtual bool ScreenLoop(string gameTag) { return true; }
    protected internal virtual bool ScreenLoop(List<List<int>> draw) { return true; }
}
