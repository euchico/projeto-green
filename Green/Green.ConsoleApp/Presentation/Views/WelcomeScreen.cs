using Green.ConsoleApp.Presentation.Helpers;

namespace Green.ConsoleApp.Presentation.Views;

internal class WelcomeScreen
{
    public void Show()
    {
        ConsoleHelper.SafeClear();
        ConfigureConsole();
        DisplayLogo();
        DisplayWelcomeMessage();
        DisplayLoadingAnimation();
        TransitionToMainMenu();
    }

    private void ConfigureConsole()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        ConsoleHelper.SetCursorVisibility(false);
    }

    private void DisplayLogo()
    {
        Console.WriteLine(@"
 ██████╗ ██████╗ ███████╗███████╗███╗   ██╗
██╔════╝ ██╔══██╗██╔════╝██╔════╝████╗  ██║
██║  ███╗██████╔╝█████╗  █████╗  ██╔██╗ ██║
██║   ██║██╔══██╗██╔══╝  ██╔══╝  ██║╚██╗██║
╚██████╔╝██║  ██║███████╗███████╗██║ ╚████║
 ╚═════╝ ╚═╝  ╚═╝╚══════╝╚══════╝╚═╝  ╚═══╝");
        Console.WriteLine();
    }

    private void DisplayWelcomeMessage()
    {
        string[] lines =
        {
            "Bem-vindo ao Green - As informações por trás da sorte.",
            "Versão 0.1 - Copyleft (ɔ) 2026 Francisco de Paula."
        };

        foreach (var line in lines)
        {
            Console.WriteLine(line);
            Thread.Sleep(500);
        }

        Console.WriteLine();
    }

    private void DisplayLoadingAnimation()
    {
        const string loadingText = "Inicializando sistema";
        const string readyText = "Sistema pronto!";
        const string dots = "...";
        const int delay = 250;

        Console.Write(loadingText);

        foreach (var dot in dots)
        {
            Console.Write(dot);
            Thread.Sleep(delay);
        }

        Console.WriteLine();
        Console.WriteLine(readyText);
        Thread.Sleep(600);
    }

    private void TransitionToMainMenu()
    {
        ConsoleHelper.SafeClear();
    }
}
