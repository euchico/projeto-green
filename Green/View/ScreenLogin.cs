using Green.Controller.General;

namespace Green.View;

internal class ScreenLogin : Screen
{
    private bool statusScreenLogin;

    internal ScreenLogin(string title) : base(title) { }

    protected internal override bool ScreenLoop()
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

            TextContent.ShowAlertMessage("AlertReturnScreenStart");
        }
        else
        {
            LoginController login = new LoginController();
            statusScreenLogin = login.UserValidation(user, password);

            if (statusScreenLogin)
            {
                statusScreenLogin = true;
                StatusLoop = false;
            }
            else
            {
              TextContent.ShowErroMessage("ErrorInvalidLoginUserOrPassword");
            }
        }
    }
}
