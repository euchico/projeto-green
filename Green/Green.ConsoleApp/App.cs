using Green.ConsoleApp.Contreoller;
using Green.ConsoleApp.Utils;
using Green.ConsoleApp.Views;

namespace Green.ConsoleApp;

internal class App
{
    private readonly WelcomeScreen _welcomeScreen;
    private readonly MainMenuController _mainMenuController;

    public App()
    {
        _welcomeScreen = new();
        _mainMenuController = new MainMenuController();
    }

    public void Run()
    {
        try
        {
            Console.ForegroundColor = ConsoleColor.Green;
            _welcomeScreen.Show();
            _mainMenuController.Run();
        }
        finally
        {
            Console.ResetColor();
            ConsoleHelper.SetCursorVisibility(true);
        }
    }
}
