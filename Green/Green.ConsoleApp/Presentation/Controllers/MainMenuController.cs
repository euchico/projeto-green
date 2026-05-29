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
                case "1":
                case "01":
                    break;

                case "2":
                case "02":
                    break;

                case "3":
                case "03":
                    break;

                case "4":
                case "04":
                    break;

                case "5":
                case "05":
                    _lotofacilMenuController.Run();
                    break;

                case "6":
                case "06":
                    break;

                case "7":
                case "07":
                    break;

                case "8":
                case "08":
                    break;

                case "9":
                case "09":
                    break;

                case "10":
                    break;

                case "11":
                    break;

                case "12":
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
