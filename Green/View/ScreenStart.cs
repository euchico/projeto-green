namespace Green.View;

internal class ScreenStart : Screen
{
    private bool statusScreenStart = true;

    internal ScreenStart(string title) : base(title) { }

    internal override bool ScreenLoop()
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
        catch (Exception e)
        {
            Message.ShowErroMessage("ErrorInvalidOption");
            StatusLoop = true;
        }
    }

    private void SelectOption(int option)
    {
        switch (option)
        {
            case 1:
                Screen screenLogin = new ScreenLogin("entrar");

                if (screenLogin.ScreenLoop())
                {
                    Screen screenMenuMain = new ScreenMenuGames("tela principal");
                    bool statusScreenMain = screenMenuMain.ScreenLoop();
                    Thread.Sleep(3000);
                }
                break;

            case 2:
                Screen screenUserCreate = new ScreenUserCreate("cadastrar usuário");
                StatusLoop = screenUserCreate.ScreenLoop();
                break;

            case 0:
                Screen screenClose = new ScreenClose("fechar");
                StatusLoop = screenClose.ScreenLoop();
                break;

            default:
                Message.ShowErroMessage("ErrorInvalidOption");
                break;
        }
    }
}
