namespace Green.ConsoleApp.Application.Interfaces;

internal interface IFileStorage
{
    void SaveToFile<T>(T data, string filePath);
}
