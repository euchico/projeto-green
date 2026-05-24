using Green.ConsoleApp.Application.UseCases;
using Green.ConsoleApp.Infrastructure.Services;
using Green.ConsoleApp.Infrastructure.Storage;
using Green.ConsoleApp.Presentation.Controllers;
using Green.ConsoleApp.Presentation.Helpers;
using Green.ConsoleApp.Presentation.Views;

namespace Green.ConsoleApp;

internal class App
{
    private readonly WelcomeScreen _welcomeScreen;
    private readonly MainMenuController _mainMenuController;

    public App()
    {
        var importLotofacilHistoryUseCase = new ImportLotofacilHistoryUseCase(
            new ExcelImportService(),
            new JsonStorage());

        var lotofacilMenuController = new LotofacilMenuController(importLotofacilHistoryUseCase);

        _welcomeScreen = new WelcomeScreen();
        _mainMenuController = new MainMenuController(lotofacilMenuController);
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
