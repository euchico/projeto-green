using System.Text.Json;
using Green.ConsoleApp.Application.Interfaces;

namespace Green.ConsoleApp.Infrastructure.Storage;

internal class JsonStorage : IFileStorage
{
    public void SaveToFile<T>(T data, string fileName)
    {
        string filePath = GetDataFilePath(fileName);
        var directory = Path.GetDirectoryName(filePath);

        if (!string.IsNullOrWhiteSpace(directory))
        {
            Directory.CreateDirectory(directory);
        }

        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        var json = JsonSerializer.Serialize(data, options);
        File.WriteAllText(filePath, json);
    }

    private string GetDataFilePath(string fileName)
    {
        string executableLocation = AppDomain.CurrentDomain.BaseDirectory;
        string projectRoot = Directory.GetParent(executableLocation).Parent.Parent.Parent.FullName;

        return Path.Combine(projectRoot, "Data", "Raw", fileName);
    }
}
