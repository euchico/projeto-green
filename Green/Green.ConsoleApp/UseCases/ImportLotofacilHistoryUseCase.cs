using Green.ConsoleApp.Services;
using Green.ConsoleApp.Utils;

namespace Green.ConsoleApp.UseCases;

internal class ImportLotofacilHistoryUseCase
{
    private const string RawFilePath = "Data/raw/lotofacil.xlsx";
    private const string ProcessedFilePath = "Data/processed/lotofacil-history.json";

    private readonly ImportService _importService;

    public ImportLotofacilHistoryUseCase()
    {
        _importService = new ImportService();
    }

    public ImportLotofacilHistoryResult Execute()
    {
        try
        {
            var history = _importService.ImportLotofacilHistory(RawFilePath);
            JsonStorage.SaveToFile(history, ProcessedFilePath);

            return ImportLotofacilHistoryResult.Success(history.Draws.Count, ProcessedFilePath);
        }
        catch (Exception exception)
        {
            return ImportLotofacilHistoryResult.Failure(exception.Message);
        }
    }
}
