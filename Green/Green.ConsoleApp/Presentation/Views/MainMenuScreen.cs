namespace Green.ConsoleApp.Presentation.Views;

internal class MainMenuScreen
{
    public string Show()
    {
        HeaderSection.Show();

        Console.WriteLine("#1.....Dia de Sorte");
        Console.WriteLine("#2.....Dupla Sena");
        Console.WriteLine("#3.....Federal");
        Console.WriteLine("#4.....Loteca");
        Console.WriteLine("#5.....Lotofácil");
        Console.WriteLine("#6.....Lotogol (Encerrado)");
        Console.WriteLine("#7.....Lotomania");
        Console.WriteLine("#8.....+Milionária");
        Console.WriteLine("#9.....Mega-Sena");
        Console.WriteLine("#10....Quina");
        Console.WriteLine("#11....Super Sete");
        Console.WriteLine("#12....Timemania\n");

        Console.WriteLine("#0.....Sair\n");

        Console.Write("Opção: ");

        return Console.ReadLine()?.Trim() ?? string.Empty;
    }

    public void ShowInvalidOptionMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Opção inválida. Tente novamente.");
    }
}
