using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idzi_Jan_2P2___ZadniaWstępne
{
    class Zadanie8
    {
        public void solution()
        {
            /*
             Napisz metodę sortującą tablicę jednowymiarową o dowolnym wymiarze metodą przez prostą zamianę (sortowanie bąbelkowe). 
             Przetestuj metodę na tablicy liczb całkowitych, elementy tablicy uzupełnij liczbami pseudolosowymi z zakresu od 1 do 100.
             */
            Console.WriteLine();
            Console.WriteLine("----------------Zadanie 8--------------");

            int a = 0;
            int b = 0;

            Console.Write("Podaj dwie liczby a i b: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"NWD z liczby {a} i {b} wynosi: {NWD(a, b)} ");

        }

        static int NWD(int a, int b)
        {
            if(b == 0){
                return a;
            }

            else
            {
                int wynik = 0;
                wynik = (NWD(b, a%b));
                return wynik;
            }
        }
    }
}
