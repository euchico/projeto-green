using static Green.Green;

namespace Green.View;

internal class ScreenMenuTasks : Screen
{
    private bool statusScreenMenuTasks;
    private string selectedGameTag;

    internal ScreenMenuTasks(string title) : base(title) { }

    internal bool ScreenLoop(string gameTag)
    {
        selectedGameTag = gameTag;

        ShowMenu();

        while (StatusLoop)
        {
            ShowHeader(ScreenTitle);
            ShowMenu();
        }

        return statusScreenMenuTasks;
    }

    private void ShowMenu()
    {
        Console.WriteLine("#1 - Entrar");
        Console.WriteLine("#2 - Cadastrar");

        Console.WriteLine("\n#0 - Sair\n");

    }
}
