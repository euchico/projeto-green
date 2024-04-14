using Green.Controller.Draw;

namespace Green.View
{
    internal class ScreenDraw : Screen
    {
        private bool statusScreenDraw;
        private string? selectedGameTag;

        internal ScreenDraw(string title) : base(title) { }

        internal override bool ScreenLoop(string gameTag)
        {
            selectedGameTag = gameTag;

            ShowMenu();

            while (StatusLoop)
            {
                ShowHeader(ScreenTitle);
                ShowMenu();
            }

            return statusScreenDraw;
        }

        private void ShowMenu()
        {
            Console.WriteLine("#1 - Sorteio Simples");
            Console.WriteLine("#2 - Sorteio Parametrizado  ");

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
                    Console.WriteLine("Seleção: Sorteio Simples");
                    Console.Write("Quantidade de Sorteios: ");
                    int numberOfDraws = int.Parse(Console.ReadLine()!);

                    Draw draw = new DrawLotofacil();

                    ScreenDrawResult screenDraw = new ScreenDrawResult("sorteio");
                    screenDraw.ScreenLoop(draw.SimpleDraw(numberOfDraws));

                    Console.ReadKey();

                    break;

                //case 2:
                //    Console.WriteLine("ANÁLISE!!!" + selectedGameTag);
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
}
