using Green.ConsoleApp.Application.Interfaces;

namespace Green.ConsoleApp.Application.UseCases;

internal class ImportLotofacilHistoryUseCase
{
    private const string RawFilePath = "Data/Raw/lotofacil.xlsx";
    private const string ProcessedFilePath = "Data/Processed/lotofacil-history.json";

    private readonly IExcelImporter _excelImporter;
    private readonly IFileStorage _fileStorage;

    public ImportLotofacilHistoryUseCase(IExcelImporter excelImporter, IFileStorage fileStorage)
    {
        _excelImporter = excelImporter;
        _fileStorage = fileStorage;
    }

    public ImportLotofacilHistoryResult Execute()
    {
        try
        {
            var history = _excelImporter.ImportLotofacilHistory(RawFilePath);
            _fileStorage.SaveToFile(history, ProcessedFilePath);

            return ImportLotofacilHistoryResult.Success(history.Draws.Count, ProcessedFilePath);
        }
        catch (Exception exception)
        {
            return ImportLotofacilHistoryResult.Failure(exception.Message);
        }
    }
}
