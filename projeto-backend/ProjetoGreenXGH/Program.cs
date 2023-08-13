namespace ProjetoGreenXGH
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu mainMenu = new MenuMain();
            mainMenu.ShowMenu();

            Console.Write("OPÇÃO: ");
            int opcao = int.Parse(Console.ReadLine()!); // Tratar exceção de entrada de "Caracteres"

            switch (opcao)
            {
                case 1:
                    if (Login())
                    {
                        Console.WriteLine("\nSISTEMA!!!!!");
                        Console.ReadKey();
                    }
                    break;

                case 2:

                    break;

                case 0:
                    FecharPrograma();
                    break;

                default:
                    Console.WriteLine("Opção Inválida!");
                    Thread.Sleep(1000);
                    break;
            }
        }

        static bool Login()
        {
            //ShowLogo();
            //ExibirTituloDaTela("LOGIN");

            Console.WriteLine("(*) Informe Usuário e Senha vazios para voltar ao Menu Inicial...\n");

            Console.Write("Usuário: ");
            string usuario = Console.ReadLine()!;

            Console.Write("Senha: ");
            string senha = Console.ReadLine()!;

            if (usuario == "" && senha == "")
            {
                Console.WriteLine("\nVoltando ao Menu Inicial...");
                Thread.Sleep(1000);

                //MenuPrincipal();
            }

            if (AutentificarUsuario(usuario, senha))
            {
                Console.WriteLine("\nSeja bem-vindo(a)!");
                return true;
            }
            else
            {
                Console.WriteLine("\nUsuário e/ou Senha incorreto!");
                Thread.Sleep(1000);

                Login();
            }
            return false;
        }

        static bool AutentificarUsuario(string usuario, string senha)
        {
            string[] linhas = File.ReadAllLines(@"C:\Users\eufra\Desenvolvimento\3-github\projeto-aventura-solo\projeto-backend\AventuraSoloGuiado\credenciais.txt");

            foreach (string linha in linhas)
            {
                string[] credencial = linha.Split(',');
                string credencialUsuario = credencial[1];
                string credencialSenha = credencial[2];

                if (credencialUsuario == usuario && credencialSenha == senha)
                {
                    return true;
                }
            }

            return false;
        }

        static void FecharPrograma()
        {
            //ExibirTituloDaTela("Fechar Programa");

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
                    FecharPrograma();
                    break;
            }
        }
    }
}