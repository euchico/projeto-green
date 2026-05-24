using Green.ConsoleApp.Application.UseCases;
using Green.ConsoleApp.Presentation.Helpers;
using Green.ConsoleApp.Presentation.Views;

namespace Green.ConsoleApp.Presentation.Controllers;

internal class LotofacilMenuController
{
    private readonly LotofacilMenuScreen _lotofacilMenuScreen;
    private readonly ImportLotofacilHistoryUseCase _importLotofacilHistoryUseCase;

    public LotofacilMenuController(ImportLotofacilHistoryUseCase importLotofacilHistoryUseCase)
    {
        _lotofacilMenuScreen = new LotofacilMenuScreen();
        _importLotofacilHistoryUseCase = importLotofacilHistoryUseCase;
    }

    public void Run()
    {
        while (true)
        {
            var option = _lotofacilMenuScreen.Show();

            switch (option)
            {
                case "1":
                    ImportLotofacilHistory();
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

    private void ImportLotofacilHistory()
    {
        var result = _importLotofacilHistoryUseCase.Execute();

        if (result.IsSuccess)
        {
            _lotofacilMenuScreen.ShowImportSuccess(result.ImportedDrawsCount, result.OutputPath);
            return;
        }

        _lotofacilMenuScreen.ShowImportError(result.ErrorMessage);
    }
}
