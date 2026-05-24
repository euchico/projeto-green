namespace Green.ConsoleApp.Application.UseCases;

internal class ImportLotofacilHistoryResult
{
    public bool IsSuccess { get; private set; }
    public int ImportedDrawsCount { get; private set; }
    public string OutputPath { get; private set; } = string.Empty;
    public string ErrorMessage { get; private set; } = string.Empty;

    public static ImportLotofacilHistoryResult Success(int importedDrawsCount, string outputPath)
    {
        return new ImportLotofacilHistoryResult
        {
            IsSuccess = true,
            ImportedDrawsCount = importedDrawsCount,
            OutputPath = outputPath
        };
    }

    public static ImportLotofacilHistoryResult Failure(string errorMessage)
    {
        return new ImportLotofacilHistoryResult
        {
            IsSuccess = false,
            ErrorMessage = errorMessage
        };
    }
}
