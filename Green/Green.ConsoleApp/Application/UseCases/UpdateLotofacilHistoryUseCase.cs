using Green.ConsoleApp.Application.Interfaces;

namespace Green.ConsoleApp.Application.UseCases;

internal class UpdateLotofacilHistoryUseCase
{
    private const string RawFileName = "lotofacil.xlsx";
    private const string ProcessedFileName = "lotofacil-history.json";

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
            var history = _excelImporter.UpdateLotofacilHistory(RawFileName);
            _fileStorage.SaveToFile(history, ProcessedFileName);

            return UpdateLotofacilHistoryResult.Success(history.Draws.Count, ProcessedFileName);
        }
        catch (Exception exception)
        {
            return UpdateLotofacilHistoryResult.Failure(exception.Message);
        }
    }
}
