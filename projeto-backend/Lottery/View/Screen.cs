namespace Lottery.View;

class Screen
{
    private string ScreenTitle { get; }
    private bool StatusLoop { get; set; }

    internal Screen(string screenTitle)
    {
        ScreenTitle = screenTitle!;
        StatusLoop = true;

        SetConsole();
        ShowHeader(ScreenTitle);
    }

    void SetConsole()
    {
        Console.Title = "Lottery";
    }

    void ShowLogo()
    {
        Console.WriteLine(@"
█░░ █▀█ ▀█▀ ▀█▀ █▀▀ █▀█ █▄█
█▄▄ █▄█ ░█░ ░█░ ██▄ █▀▄ ░█░");
        Console.WriteLine();
    }

    void ShowScreenTitle(string screenTitle)
    {
        string topBorder = string.Empty.PadRight(screenTitle.Length + 4, '▄');
        string bottomBorder = string.Empty.PadRight(screenTitle.Length + 4, '▀');

        Console.WriteLine(topBorder);
        Console.WriteLine($"▐ {screenTitle.ToUpper()} ▌");
        Console.WriteLine(bottomBorder + "\n");
    }

    void ShowHeader(string screenTitle)
    {
        Console.Clear();

        ShowLogo();
        ShowScreenTitle(screenTitle);
    }

    //internal abstract bool ScreenLoop();
}
