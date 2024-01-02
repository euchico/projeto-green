using static Green.Green;

namespace Green.View;

internal class ScreenMenuGames : Screen
{
    private bool statusScreenMenuGames;

    internal ScreenMenuGames(string title) : base(title) { }

    internal override bool ScreenLoop()
    {
        ShowMenu();

        while (StatusLoop)
        {
            ShowHeader(ScreenTitle);
            ShowMenu();
        }

        return statusScreenMenuGames;
    }

    private void ShowMenu()
    {
        Console.WriteLine("Selecione um Jogo:");

        foreach (Game game in Green.GameList())
        {
            Console.WriteLine($"#{(game.Id + 1).ToString("00")} - {game.Name}");
        }

        Console.WriteLine("\n#0 - Sair\n");

        Console.Write("Opção: ");

        try
        {
            int option = int.Parse(Console.ReadLine()!);
            
            Screen screenMenuTasks = new ScreenMenuTasks("");
            screenMenuTasks.ScreenLoop(Green.GameList()[option].Tag);
        }
        catch (Exception e)
        {
            Message.ShowErroMessage("ErrorInvalidOption");
            StatusLoop = true;
        }
    }
}
