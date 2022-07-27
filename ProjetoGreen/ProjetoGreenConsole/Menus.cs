using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGreenConsole
{
    internal class Menus
    {
        public bool MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("PROJETO GREEN\n");

            Console.WriteLine("Escolha uma Loteria:");

            Console.WriteLine("01) Dia de Sorte");
            Console.WriteLine("02) Dupla Sena");
            Console.WriteLine("03) Federal");
            Console.WriteLine("04) Loteca");
            Console.WriteLine("05) Lotofácil");
            Console.WriteLine("06) Lotogol");
            Console.WriteLine("07) Lotomania");
            Console.WriteLine("08) +Milionária");
            Console.WriteLine("09) Mega-Sena");
            Console.WriteLine("10) Quina");
            Console.WriteLine("11) Super Sete");
            Console.WriteLine("12) Timemania");

            Console.WriteLine("13) Sair");

            Console.Write("\nDigite a sua opção: ");
            switch (Console.ReadLine())
            {
                case "01":
                    Console.WriteLine("\nVocê selecionou: Dia de Sorte");
                    MenuLoteria("Dia de Sorte");
                    Console.ReadLine();
                    return true;
                case "02":
                    Console.WriteLine("\nVocê selecionou: Dupla Sena");
                    Console.ReadLine();
                    return true;
                case "03":
                    Console.WriteLine("\nVocê selecionou: Federal");
                    Console.ReadLine();
                    return true;
                case "04":
                    Console.WriteLine("\nVocê selecionou: Loteca");
                    Console.ReadLine();
                    return true;
                case "05":
                    Console.WriteLine("\nVocê selecionou: Lotofácil");
                    Console.ReadLine();
                    return true;
                case "06":
                    Console.WriteLine("\nVocê selecionou: Lotogol");
                    Console.ReadLine();
                    return true;
                case "07":
                    Console.WriteLine("\nVocê selecionou: Lotomania");
                    Console.ReadLine();
                    return true;
                case "08":
                    Console.WriteLine("\nVocê selecionou: +Milionária");
                    Console.ReadLine();
                    return true;
                case "09":
                    Console.WriteLine("\nVocê selecionou: Mega-Sena");
                    Console.ReadLine();
                    return true;
                case "10":
                    Console.WriteLine("\nVocê selecionou: Quina");
                    Console.ReadLine();
                    return true;
                case "11":
                    Console.WriteLine("\nVocê selecionou: Super Sete");
                    Console.ReadLine();
                    return true;
                case "12":
                    Console.WriteLine("\nVocê selecionou: Timemania");
                    Console.ReadLine();
                    return true;
                case "13":
                    Console.WriteLine("\nVocê selecionou: Sair");
                    return false;
                default:
                    Console.WriteLine("\nEscolha uma opção válida!");
                    Console.ReadLine();
                    return true;
            }
        }

        private bool MenuLoteria(string opcaoLoteria)
        {
            //bool mostrarMenu = true;


            Console.Clear();
            Console.WriteLine("PROJETO GREEN\n");

            Console.WriteLine(opcaoLoteria + ":");

            Console.WriteLine("1) Estatistica");
            Console.WriteLine("2) Fazer um Sorteio");

            Console.WriteLine("3) Sair");

            Console.Write("\nDigite a sua opção: ");
            switch (Console.ReadLine())
            {
                case "01":
                    Console.WriteLine("\nEstatistica");
                    Console.ReadLine();
                    return true;
                case "02":
                    Console.WriteLine("\nFazer um Sorteio");
                    Console.ReadLine();
                    return true;
                case "03":
                    Console.WriteLine("\nVocê selecionou: Sair");
                    return false;
                default:
                    Console.WriteLine("\nEscolha uma opção válida!");
                    Console.ReadLine();
                    return true;
            }
        }
    }
}
