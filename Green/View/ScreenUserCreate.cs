using Green.Controller.General;
using System.Text.RegularExpressions;

namespace Green.View;

internal class ScreenUserCreate : Screen
{
    private bool statusScreenUserCreate;

    internal ScreenUserCreate(string title) : base(title) { }

    internal override bool ScreenLoop()
    {
        ShowMenu();

        while (StatusLoop)
        {
            ShowHeader(ScreenTitle);
            ShowMenu();
        }

        return statusScreenUserCreate;
    }

    private void ShowMenu()
    {
        Console.WriteLine("Informe os dados do(a) usuário(a).\n");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("(*) Informe Usuário e Senha vazios para voltar ao Início.");
        Console.WriteLine("    Utilize somente caracteres alfanuméricos (letras e números).\n");
        Console.ResetColor();

        Console.Write("Usuário: ");
        string user = Console.ReadLine()!;

        Console.Write("Senha: ");
        string password = Console.ReadLine()!;

        if (user == "" && password == "")
        {
            StatusLoop = false;
            statusScreenUserCreate = true;

            Message.ShowAlertMessage("AlertReturnScreenStart");
        }
        else if (CheckSpecialChar(user) || CheckSpecialChar(password))
        {
            Message.ShowErroMessage("ErrorLoginWithSpecialCharacter");
            StatusLoop = true;
        }
        else
        {
            Console.Write("Confirme a Senha: ");
            string confirmPassword = Console.ReadLine()!;

            if (password != confirmPassword)
            {
                Message.ShowErroMessage("ErrorUnconfirmedPassword");
            }
            else
            {
                StatusLoop = false;
                statusScreenUserCreate = true;

                UserController userController = new UserController();
                userController.CreateUser(user, password);

                Message.ShowSucessMessage("SucessRegisteredUser", user);
            }
        }
    }

    private bool CheckSpecialChar(string word)
    {
        string pattern = @"[^a-zA-Z0-9]";
        Regex regex = new Regex(pattern);

        return regex.IsMatch(word) ? true : false;
    }
}
