namespace Green.View;

internal class ScreenLogin : Screen
{
    private bool statusScreenLogin;

    internal ScreenLogin(string title) : base(title) { }

    internal override bool ScreenLoop()
    {
        ShowMenu();

        while (StatusLoop)
        {
            ShowHeader(ScreenTitle);
            ShowMenu();
        }

        return statusScreenLogin;
    }

    private void ShowMenu()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("(*) Informe Usuário e Senha vazios para voltar ao Início.\n");
        Console.ResetColor();

        Console.Write("Usuário: ");
        string user = Console.ReadLine()!;

        Console.Write("Senha: ");
        string password = Console.ReadLine()!;

        if (user == "" && password == "")
        {
            StatusLoop = false;
            statusScreenLogin = false;

            Message.ShowAlertMessage("AlertReturnScreenStart");
        }
        else
        {
            //Logon logon = new Logon();
            //statusLogonScreen = logon.UserValidation(user, password);

            if (user == "admin" && password == "admin")
            {
                statusScreenLogin = true;
                StatusLoop = false;
            }
            else
            {
               // Message.ShowErroMessage("IncorrectLogon");
            }
        }
    }
}
