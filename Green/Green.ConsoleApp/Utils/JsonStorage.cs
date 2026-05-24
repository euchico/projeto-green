using System.Text.Json;

namespace Green.ConsoleApp.Utils;

public static class JsonStorage
{
    public static void SaveToFile<T>(T data, string filePath)
    {
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
}
