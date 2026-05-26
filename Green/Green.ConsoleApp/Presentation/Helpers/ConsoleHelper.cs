namespace Green.ConsoleApp.Presentation.Helpers;

public static class ConsoleHelper
{
    public static void SafeClear()
    {
        try
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

        }
        catch (IOException)
        {
            // Em execuções com entrada/saída redirecionadas, Console.Clear pode falhar.
        }
    }

    public static void SetCursorVisibility(bool isVisible)
    {
        try
        {
            Console.CursorVisible = isVisible;
        }
        catch (IOException)
        {
            // Sem console interativo, o cursor pode não estar disponível.
        }
    }

    public static void WaitForUser()
    {
        Console.WriteLine();
        Console.Write("Pressione qualquer tecla para continuar...");

        if (Console.IsInputRedirected)
        {
            Console.ReadLine();
            return;
        }

        Console.ReadKey(intercept: true);
    }
}
