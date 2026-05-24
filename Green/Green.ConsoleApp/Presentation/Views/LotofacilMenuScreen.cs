namespace Green.ConsoleApp.Presentation.Views;

internal class LotofacilMenuScreen
{
    public string Show()
    {
        HeaderSection.Show();

        Console.WriteLine("Lotofácil");
        Console.WriteLine();
        Console.WriteLine("1 - Importar histórico");
        Console.WriteLine("0 - Voltar");
        Console.WriteLine();
        Console.Write("Opção: ");

        return Console.ReadLine()?.Trim() ?? string.Empty;
    }

    public void ShowImportSuccess(int totalDraws, string outputPath)
    {
        Console.WriteLine();
        Console.WriteLine($"Importação concluída com sucesso. Total de concursos importados: {totalDraws}.");
        Console.WriteLine($"Arquivo salvo em: {outputPath}");
    }

    public void ShowImportError(string message)
    {
        Console.WriteLine();
        Console.WriteLine($"Erro ao importar histórico: {message}");
    }

    public void ShowInvalidOptionMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Opção inválida. Tente novamente.");
    }
}
