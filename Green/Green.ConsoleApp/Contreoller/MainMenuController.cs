using Green.ConsoleApp.Utils;
using Green.ConsoleApp.Views;

namespace Green.ConsoleApp.Contreoller;

internal class MainMenuController
{
    private readonly MainMenuScreen _mainMenuScreen;
    private readonly LotofacilMenuController _lotofacilMenuController;

    public MainMenuController()
    {
        _mainMenuScreen = new();
        _lotofacilMenuController = new LotofacilMenuController();
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
