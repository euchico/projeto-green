using Green.ConsoleApp.Application.UseCases;
using Green.ConsoleApp.Presentation.Helpers;
using Green.ConsoleApp.Presentation.Views;

namespace Green.ConsoleApp.Presentation.Controllers;

internal class LotofacilMenuController
{
    private readonly LotofacilMenuScreen _lotofacilMenuScreen;
    private readonly UpdateLotofacilHistoryUseCase _updateLotofacilHistoryUseCase;

    public LotofacilMenuController(UpdateLotofacilHistoryUseCase importLotofacilHistoryUseCase)
    {
        _lotofacilMenuScreen = new LotofacilMenuScreen();
        _updateLotofacilHistoryUseCase = importLotofacilHistoryUseCase;
    }

    public void Run()
    {
        UpdateLotofacilHistory();

        while (true)
        {
            var option = _lotofacilMenuScreen.Show();

            switch (option)
            {
                case "1":
                    
                    ConsoleHelper.WaitForUser();
                    break;
                case "0":
                    return;
                default:
                    _lotofacilMenuScreen.ShowInvalidOptionMessage();
                    ConsoleHelper.WaitForUser();
                    break;
            }
        }
    }

    private void UpdateLotofacilHistory()
    {
        var result = _updateLotofacilHistoryUseCase.Execute();

        if (result.IsSuccess)
        {
            _lotofacilMenuScreen.ShowImportSuccess(result.ImportedDrawsCount, result.OutputPath);
            return;
        }

        _lotofacilMenuScreen.ShowImportError(result.ErrorMessage);
    }
}
