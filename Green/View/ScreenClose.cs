namespace Green.View;

internal class ScreenClose : Screen
{
    private bool statusCloseScreen;

    internal ScreenClose(string title) : base(title) { }

    internal override bool ScreenLoop()
    {
        ShowMenu();

        while (StatusLoop)
        {
            ShowHeader(ScreenTitle);
            ShowMenu();
        }

        return !statusCloseScreen;
    }

    private void ShowMenu()
    {
        Console.WriteLine("Tem certeza que deseja fechar o Programa?\n");

        Console.WriteLine("#S - Sim");
        Console.WriteLine("#N - Não\n");

        Console.Write("Opção: ");
        string option = Console.ReadLine()!;

        SelectOption(option.ToUpper());
    }

    private void SelectOption(string option)
    {
        switch (option)
        {
            case "S":
                Message.ShowSucessMessage("SucessThanksAccess");

                StatusLoop = false;
                statusCloseScreen = true;
                break;

            case "N":
                Message.ShowAlertMessage("AlertReturnScreenStart");

                StatusLoop = false;
                statusCloseScreen = false;
                break;

            default:
                Message.ShowErroMessage("ErrorInvalidOption");
                break;
        }
    }
}
