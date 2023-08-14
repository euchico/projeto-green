namespace ProjetoGreenXGH.Screens
{
    class ScreenMain : Screen
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
            ShowHeader("menu inicial");

            switch (Menu())
            {
                case 1:
                ScreenAuthentication screenAuthentication = new ScreenAuthentication();
                screenAuthentication.ShowScreen();
                break;

                case 0:
                    CloseProjetoGreen();
                    break;

                default:
                    Console.WriteLine("Opção Inválida!");
                    Thread.Sleep(1000);
                    break;
            }
        }

        private int Menu()
        {
            Console.WriteLine("#1 - ENTRAR");
            Console.WriteLine("#2 - CADASTRAR");
            Console.WriteLine("\n#0 - FECHAR\n");

            Console.Write("OPÇÃO: ");
            int option = int.Parse(Console.ReadLine()!); // Tratar exceção de entrada de "Caracteres"

            return option;
        }

        private void CloseProjetoGreen()
        {
            Console.WriteLine("Todo progresso será perdido!!!");
            Console.WriteLine("Tem certeza que deseja fechar o programa?\n");

            Console.Write("OPÇÃO (S/N): ");
            string opcao = (Console.ReadLine()!).ToUpper();

            switch (opcao)
            {
                case "N":
                    //MenuPrincipal();
                    break;

                case "S":
                    Console.WriteLine("\nObrigado! Até a próxima aventura...   ");
                    Thread.Sleep(3000);
                    break;

                default:
                    Console.WriteLine("\nOpção Inválida!");
                    Thread.Sleep(1000);
                    CloseProjetoGreen();
                    break;
            }
        }
    }
}
