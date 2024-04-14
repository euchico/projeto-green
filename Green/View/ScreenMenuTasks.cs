using static Green.Green;

namespace Green.View;

internal class ScreenMenuTasks : Screen
{
    private bool statusScreenMenuTasks;
    private string? selectedGameTag;

    internal ScreenMenuTasks(string title) : base(title) { }

    internal override bool ScreenLoop(string gameTag)
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
        Console.WriteLine("#1 - Sorteio");
        //Console.WriteLine("#2 - Análise");
        //Console.WriteLine("#3 - Estatística");

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
        switch (option)
        {
            case 1:
                ScreenDraw screenDraw = new ScreenDraw("sorteio");
                screenDraw.ScreenLoop("lotofacil");

                break;

            //case 2:
            //    Console.WriteLine("ANÁLISE!!!" + selectedGameTag);
            //    Thread.Sleep(3000);

            //    break;

            //case 3:
            //    Console.WriteLine("ESTATÍSTICA!!!" + selectedGameTag);
            //    Thread.Sleep(3000);

            //    break;

            case 0:
                Screen screenMenuMain = new ScreenMenuGames("seleção de jogo");
                bool statusScreenMain = screenMenuMain.ScreenLoop();

                break;

            default:
                TextContent.ShowErroMessage("ErrorInvalidOption");
                break;
        }

    }
}
