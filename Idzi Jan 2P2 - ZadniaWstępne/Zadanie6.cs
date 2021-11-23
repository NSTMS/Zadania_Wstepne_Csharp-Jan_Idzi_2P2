using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idzi_Jan_2P2___ZadniaWstępne
{
    class Zadanie6
    {
        public void solution()
        {
            /*
             Napisz metodę sortującą tablicę jednowymiarową o dowolnym wymiarze metodą przez prostą zamianę (sortowanie bąbelkowe). 
             Przetestuj metodę na tablicy liczb całkowitych, elementy tablicy uzupełnij liczbami pseudolosowymi z zakresu od 1 do 100.
             */
            Console.WriteLine();
            Console.WriteLine("----------------Zadanie 6--------------");


            Random random = new Random();

            int[] tab = new int[10];
            int helper;
            Console.WriteLine("Liczby przed posortowaniem: ");
            for (int i = 0; i < 10; i++)
            {
                tab[i] = random.Next(1, 101);
                Console.Write(tab[i] + ", ");
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10 - 1; j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        helper = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = helper;
                    }

                }
            }
            Console.WriteLine();
            Console.WriteLine("Liczby po posortowaniu: ");

            for (int i = 0; i < 10; i++)
            {
                Console.Write(tab[i] + ", ");
            }
            Console.WriteLine();

        }
    }
}
