namespace Green.ConsoleApp.Application.UseCases;

internal class UpdateLotofacilHistoryResult
{
    public bool IsSuccess { get; private set; }
    public int ImportedDrawsCount { get; private set; }
    public string OutputPath { get; private set; } = string.Empty;
    public string ErrorMessage { get; private set; } = string.Empty;

    public static UpdateLotofacilHistoryResult Success(int importedDrawsCount, string outputPath)
    {
        return new UpdateLotofacilHistoryResult
        {
            IsSuccess = true,
            ImportedDrawsCount = importedDrawsCount,
            OutputPath = outputPath
        };
    }

    public static UpdateLotofacilHistoryResult Failure(string errorMessage)
    {
        return new UpdateLotofacilHistoryResult
        {
            IsSuccess = false,
            ErrorMessage = errorMessage
        };
    }
}
