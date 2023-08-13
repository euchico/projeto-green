using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGreenXGH
{
    abstract class Menu
    {
        public void ShowLogo()
        {
            Console.Clear();
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

        public abstract void ShowMenu();
    }
}
