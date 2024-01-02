namespace Green.Utility;

internal class DataFile
{
    internal static string GetDataFilePath(string file)
    {
        string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        string completeFilePath = Path.Combine(currentDirectory, @$"..\..\..\Data\{file}");

        return completeFilePath;
    }
}
