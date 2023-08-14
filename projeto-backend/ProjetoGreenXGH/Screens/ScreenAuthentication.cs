using ProjetoGreenXGH.Utility;

namespace ProjetoGreenXGH.Screens
{
    class ScreenAuthentication : Screen
    {
        public override void ScreenLoop()
        {
            do
            {
                ShowScreen();

            } while (true);
        }

        public override void ShowScreen()
        {
            ShowHeader("entrar");

            Console.WriteLine("(*) Informe Usuário e Senha vazios para voltar ao Menu Inicial...\n");

            Console.Write("Usuário: ");
            string usuario = Console.ReadLine()!;

            Console.Write("Senha: ");
            string senha = Console.ReadLine()!;
            
            if (usuario == "" && senha == "")
            {
                Console.WriteLine("\nVoltando ao Menu Inicial...");
                Thread.Sleep(1000);

                Screen mainScreen = new ScreenMain();
                mainScreen.ScreenLoop();
            }

            Authentication authentication = new Authentication();
  
            if (authentication.Login(usuario, senha))
            {
                Console.WriteLine("\nLogin bem-sucedido!");
                Console.WriteLine("SISTEMA!");
                Thread.Sleep(2000);  
            }
            else
            {
                Console.WriteLine("\nUsuário e/ou Senha incorreto!");
                Thread.Sleep(2000);
            }
        }
    }
}
