namespace Green.View;

internal class ScreenStart : Screen
{
    private bool statusScreenStart = true;

    internal ScreenStart(string title) : base(title) { }

    protected internal override bool ScreenLoop()
    {
        ShowMenu();

        while (StatusLoop)
        {
            ShowHeader(ScreenTitle);
            ShowMenu();
        }

        return statusScreenStart;
    }

    private void ShowMenu()
    {
        Console.WriteLine("#1 - Entrar");
        Console.WriteLine("#2 - Cadastrar");

        Console.WriteLine("\n#0 - Fechar\n");

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

    protected void SelectOption(int option)
    {
        switch (option)
        {
            case 1:
                Screen screenLogin = new ScreenLogin(TextContent.GetTitle("ScreenTitleLogin"));

                if (screenLogin.ScreenLoop())
                {
                    Screen screenMenuMain = new ScreenMenuGames(TextContent.GetTitle("ScreenTitleMenuGames"));
                    bool statusScreenMain = screenMenuMain.ScreenLoop();
                    Thread.Sleep(3000);
                }
                break;

            case 2:
                Screen screenUserCreate = new ScreenUserCreate(TextContent.GetTitle("ScreenTitleUserCreate"));
                StatusLoop = screenUserCreate.ScreenLoop();
                break;

            case 0:
                Screen screenClose = new ScreenClose(TextContent.GetTitle("ScreenTitleClose"));
                StatusLoop = screenClose.ScreenLoop();
                break;

            default:
                TextContent.ShowErroMessage("ErrorInvalidOption");
                break;
        }
    }
}
