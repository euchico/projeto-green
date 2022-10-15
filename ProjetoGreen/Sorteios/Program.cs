using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorteios
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis
            int qtdSorteios = 12;
            int qtdBolas = 15;
            var sorteio = new ConcursoSorteio[qtdSorteios];
            int i,j = 0;

            // Inicialização de arrays
            for (i = 0; i < qtdSorteios; i++)
            {
                sorteio[i] = new ConcursoSorteio();
                sorteio[i].bola = new int[qtdBolas];
            }

            // Sorteio
            i = 0;
            while (i < qtdSorteios)
            {
                bool sorteioRepetido = false;
                j = 0;

                while (j < qtdBolas)
                {
                    Random aleatorio = new Random();
                    bool novoNumero = true;

                    while (novoNumero)
                    {
                        int numeroSorteado = aleatorio.Next(1, 26);

                        if (Array.Exists(sorteio[i].bola, element => element == numeroSorteado))
                        {
                            
                        }
                        else
                        {
                            sorteio[i].bola[j] = numeroSorteado;
                            novoNumero = false;
                        }
                    }

                    if (!sorteioRepetido)
                    {
                        j++;
                    }
                }

                for (int k = (i-1); k > 0; k--)
                {
                    if (sorteio[i].bola.SequenceEqual(sorteio[k].bola))
                    {
                        sorteioRepetido = true;
                    }
                }

                if (!sorteioRepetido)
                {
                    Array.Sort(sorteio[i].bola);
                    i++;
                }
            }

            // Print dos sorteios
            for (i = 0; i < qtdSorteios; i++)
            {
                Console.Write("#" + (i+1).ToString("00") + ": ");

                for (j = 0; j < qtdBolas; j++)
                {
                    Console.Write(sorteio[i].bola[j].ToString("00") + " ");
                }

                Console.WriteLine("");
            }  
        }
    }
}