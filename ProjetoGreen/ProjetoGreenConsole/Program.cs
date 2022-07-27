using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGreenConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            bool mostrarMenu = true;
            Menus menuPrincipal = new Menus();

            while (mostrarMenu)
            {
                mostrarMenu = menuPrincipal.MenuPrincipal();
            }
        }
    }
}

