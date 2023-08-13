using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGreenXGH
{
    class MenuMain : Menu
    {

        public override void ShowMenu()
        {
            ShowHeader("MENU INICIAL");

            Console.WriteLine("#1 - ENTRAR");
            Console.WriteLine("#2 - CADASTRAR");
            Console.WriteLine("\n#0 - SAIR\n");
        }
    }
}
