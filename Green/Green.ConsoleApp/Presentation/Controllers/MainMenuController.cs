using Green.ConsoleApp.Presentation.Helpers;
using Green.ConsoleApp.Presentation.Views;

namespace Green.ConsoleApp.Presentation.Controllers;

internal class MainMenuController
{
    private readonly MainMenuScreen _mainMenuScreen;
    private readonly LotofacilMenuController _lotofacilMenuController;

    public MainMenuController(LotofacilMenuController lotofacilMenuController)
    {
        _mainMenuScreen = new MainMenuScreen();
        _lotofacilMenuController = lotofacilMenuController;
    }

    public void Run()
    {
        while (true)
        {
            var option = _mainMenuScreen.Show();

            switch (option)
            {
                case "5":
                case "05":
                    _lotofacilMenuController.Run();
                    break;
                case "0":
                    Console.WriteLine();
                    Console.WriteLine("Encerrando aplicação.");
                    return;
                default:
                    _mainMenuScreen.ShowInvalidOptionMessage();
                    ConsoleHelper.WaitForUser();
                    break;
            }
        }
    }
}
