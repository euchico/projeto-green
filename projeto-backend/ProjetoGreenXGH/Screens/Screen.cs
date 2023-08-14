namespace ProjetoGreenXGH.Screens
{
    abstract class Screen
    {
        public void SetConsole()
        {
            Console.Title = "Projeto Green XGH";
        }

        public void ShowLogo()
        {
            Console.WriteLine(@"
█▀█ █▀█ █▀█ ░░█ █▀▀ ▀█▀ █▀█   █▀▀ █▀█ █▀▀ █▀▀ █▄░█
█▀▀ █▀▄ █▄█ █▄█ ██▄ ░█░ █▄█   █▄█ █▀▄ ██▄ ██▄ █░▀█
             ");
        }

        public void ShowScreenTitle(string title)
        {
            string borda = string.Empty.PadRight(title.Length + 4, '■');

            Console.WriteLine(borda);
            Console.WriteLine("■ " + title.ToUpper() + " ■");
            Console.WriteLine(borda + "\n");
        }

        public void ShowHeader(string title)
        {
            Console.Clear();

            ShowLogo();
            ShowScreenTitle(title);
        }
        public abstract void ScreenLoop();
        public abstract void ShowScreen();

    }
}
