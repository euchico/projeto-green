using ProjetoGreenXGH.Screens;

namespace ProjetoGreenXGH
{
    class ProjetoGreen
    {
        static void Main(string[] args)
        {
            Screen mainScreen = new ScreenMain();

            mainScreen.SetConsole();
            mainScreen.ScreenLoop();       
        }   
    }
}