using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idzi_Jan_2P2___ZadniaWstępne
{
    class Zadanie7
    {
        public void solution()
        {
            /*
             *Korzystając z dwuwymiarowej tablicy, napisz metodę, który wyświetli tabelę reprezentującą trójkąt Pascala o dowolnym rozmiarze.
              W trójkącie Pascala pierwszy i drugi wiersz są ustawione na 1.Każdy element trójkąta(od trzeciego rzędu w dół) 
              jest sumą elementu znajdującego się bezpośrednio nad nim i elementu po lewej stronie elementu znajdującego się 
              bezpośrednio nad nim.Zobacz przykład trójkąta Pascala(rozmiar = 7) poniżej:

         1
         1   1
         1   2   1
         1   3   3   1
         1   4   6   4   1
         1   5  10  10   5   1
         1   6  15  20  15   6   1


             */
            Console.WriteLine();
            Console.WriteLine("----------------Zadanie 7--------------");


            int rozmiar = 0;

            Console.Write("Podaj wymiar tablicy: ");
            rozmiar = Convert.ToInt32(Console.ReadLine());

            int[,] tab = new int[rozmiar, rozmiar];

            for (int i = 0; i < rozmiar; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                    {
                        tab[i, j] = 1;
                    }
                    else
                    {
                        tab[i, j] = tab[i - 1, j - 1] + tab[i - 1, j];
                    }
                }
            }

            for (int i = 0; i < rozmiar; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(tab[i,j] + "");
                }
                Console.Write("\n" + "");
            }







        }
    }
}
