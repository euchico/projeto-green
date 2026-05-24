using Green.ConsoleApp.UseCases;
using Green.ConsoleApp.Utils;
using Green.ConsoleApp.Views;

namespace Green.ConsoleApp.Contreoller;

internal class LotofacilMenuController
{
    private readonly LotofacilMenuScreen _lotofacilMenuScreen;
    private readonly ImportLotofacilHistoryUseCase _importLotofacilHistoryUseCase;

    public LotofacilMenuController()
    {
        _lotofacilMenuScreen = new();
        _importLotofacilHistoryUseCase = new ImportLotofacilHistoryUseCase();
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
