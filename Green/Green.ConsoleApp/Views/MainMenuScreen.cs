namespace Green.ConsoleApp.Views;

internal class MainMenuScreen
{
    public string Show()
    {
        HeaderSection.Show();

        Console.WriteLine("#05 - Lotofácil");
        Console.WriteLine();
        Console.WriteLine("#0 - Sair");
        Console.WriteLine();
        Console.Write("Opção: ");

        return Console.ReadLine()?.Trim() ?? string.Empty;
    }

    public void ShowInvalidOptionMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Opção inválida. Tente novamente.");
    }
}
