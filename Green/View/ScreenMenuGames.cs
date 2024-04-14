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
            SelectOption(option);
        }
        catch
        {
            TextContent.ShowErroMessage("ErrorInvalidOption");
            StatusLoop = true;
        }
    }

    private void SelectOption(int option)
    {
        int selectOption = option;

        if (selectOption > 0 && selectOption < Green.GameList().Count)
        {
            ScreenMenuTasks screenMenuTask = new ScreenMenuTasks("tarefa");
            screenMenuTask.ScreenLoop("LOTERIA");
        }
        else if (option == 0)
        {
            TextContent.ShowAlertMessage("AlertReturnScreenStart");
            
            Screen mainScreen = new ScreenStart("início");
            mainScreen.ScreenLoop();
        }
        else
        {
            TextContent.ShowErroMessage("ErrorInvalidOption");
        }
    }
}
