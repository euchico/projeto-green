using Green.ConsoleApp.Application.Interfaces;

namespace Green.ConsoleApp.Application.UseCases;

internal class UpdateLotofacilHistoryUseCase
{
    private const string RawFilePath = "lotofacil.xlsx";
    private const string ProcessedFilePath = "Data/Processed/lotofacil-history.json";

    private readonly IExcelImporter _excelImporter;
    private readonly IFileStorage _fileStorage;

    public UpdateLotofacilHistoryUseCase(IExcelImporter excelImporter, IFileStorage fileStorage)
    {
        _excelImporter = excelImporter;
        _fileStorage = fileStorage;
    }

    public UpdateLotofacilHistoryResult Execute()
    {
        try
        {
            var history = _excelImporter.UpdateLotofacilHistory(RawFilePath);
            _fileStorage.SaveToFile(history, ProcessedFilePath);

            return UpdateLotofacilHistoryResult.Success(history.Draws.Count, ProcessedFilePath);
        }
        catch (Exception exception)
        {
            return UpdateLotofacilHistoryResult.Failure(exception.Message);
        }
    }
}
